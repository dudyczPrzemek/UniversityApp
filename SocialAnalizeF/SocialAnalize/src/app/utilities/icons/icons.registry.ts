import { Injectable } from '@angular/core';
import { MatIconRegistry } from '@angular/material';
import { DomSanitizer } from '@angular/platform-browser';

class IconMap {
  constructor(public name: string,
    public path: string) {
  }
}

@Injectable()
export class IconRegistry {
  static readonly defaultSvgIcons: IconMap[] = [
    new IconMap('plus', '../../assets/images/plus.svg')
  ];

  constructor(private matIconRegistry: MatIconRegistry,
    private sanitizer: DomSanitizer) {
  }

  public registerDefaultSvgIcons(): void {
    IconRegistry.defaultSvgIcons
      .forEach(icon => this.registerSvgIcon(icon.name, icon.path));
  }

  public registerSvgIcon(name: string, path: string): void {
    this.matIconRegistry
      .addSvgIcon(name, this.sanitizer.bypassSecurityTrustResourceUrl(path));
  }
}
