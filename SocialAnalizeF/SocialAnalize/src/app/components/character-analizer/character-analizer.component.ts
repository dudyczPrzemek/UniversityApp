import { ChartModel } from './../../models/chart/chart.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-character-analizer',
  templateUrl: './character-analizer.component.html',
  styleUrls: ['./character-analizer.component.scss']
})
export class CharacterAnalizerComponent implements OnInit {
  public sentimentChartModel: ChartModel;

  constructor() {
    this.initSentimentChartModel();
  }

  ngOnInit() {
  }

  initSentimentChartModel() {
    this.sentimentChartModel = new ChartModel();
    this.sentimentChartModel.showLegend = true;
    this.sentimentChartModel.showXAxis = true;
    this.sentimentChartModel.showYAxis = true;
    this.sentimentChartModel.gradient = false;
    this.sentimentChartModel.showLegend = true;
    this.sentimentChartModel.showXAxisLabel = true;
    this.sentimentChartModel.xAxisLabel = 'Sentiment';
    this.sentimentChartModel.showYAxisLabel = true;
    this.sentimentChartModel.yAxisLabel = 'Count';
    this.sentimentChartModel.view = [600, 200];
    this.sentimentChartModel.colorScheme = {
      domain: ['#5AA454', '#A10A28', '#C7B42C', '#000000']
    };
    this.sentimentChartModel.data = [
      {
        'name': 'positive',
        'value': 15
      },
      {
        'name': 'negative',
        'value': 8
      }
    ];
  }
}
