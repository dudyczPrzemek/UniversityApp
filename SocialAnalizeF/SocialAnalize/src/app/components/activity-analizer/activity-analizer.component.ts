import { ChartModel } from './../../models/chart/chart.model';
import { Component, OnInit } from '@angular/core';
import { InternetActivityService } from '../../services/internetActivity/internet.activity.service';

@Component({
  selector: 'app-activity-analizer',
  templateUrl: './activity-analizer.component.html',
  styleUrls: ['./activity-analizer.component.scss']
})
export class ActivityAnalizerComponent implements OnInit {
  public hashtagChartModel: ChartModel;
  public hourActivityChart: ChartModel;

  constructor(private internetActivityService: InternetActivityService) { }

  ngOnInit() {
    this.internetActivityService.load().subscribe(result => {
      debugger;
      var jsonResult = result.json();

      this.initHashtagChartModel(jsonResult.hashtagDetails);
      this.initHourActivityChart(jsonResult.instagramHourActivity, jsonResult.twitterHourActivity);
    });
  }

  private initHashtagChartModel(hashtagsArray) {
    this.hashtagChartModel = new ChartModel();
    this.hashtagChartModel.showLegend = true;
    this.hashtagChartModel.showXAxis = true;
    this.hashtagChartModel.showYAxis = true;
    this.hashtagChartModel.gradient = false;
    this.hashtagChartModel.showLegend = true;
    this.hashtagChartModel.showXAxisLabel = true;
    this.hashtagChartModel.xAxisLabel = 'Hashtag';
    this.hashtagChartModel.showYAxisLabel = true;
    this.hashtagChartModel.yAxisLabel = 'Count';
    this.hashtagChartModel.view = [600, 200];
    this.hashtagChartModel.colorScheme = {
      domain: ['#5AA454', '#A10A28', '#C7B42C', '#000000']
    };
    this.hashtagChartModel.data = [];

    for(var i = 0; i < hashtagsArray.length; ++i) {
      this.hashtagChartModel.data.push(
        {
          'name': hashtagsArray[i].name,
          'value': hashtagsArray[i].count
        });
    }
  }

  private initHourActivityChart(instagramArray, twitterArray) {
    this.hourActivityChart = new ChartModel();
    this.hourActivityChart.view = [600, 200];
    this.hourActivityChart.showXAxis = true;
    this.hourActivityChart.showYAxis = true;
    this.hourActivityChart.gradient = false;
    this.hourActivityChart.showLegend = true;
    this.hourActivityChart.showXAxisLabel = true;
    this.hourActivityChart.xAxisLabel = 'Hours';
    this.hourActivityChart.showYAxisLabel = true;
    this.hourActivityChart.yAxisLabel = 'Activities count';
    this.hourActivityChart.colorScheme = {
      domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
    };
    this.hourActivityChart.autoScale = true;
    this.hourActivityChart.data = [
      {
        'name': 'Instagram',
        'series': instagramArray
      },
      {
        'name': 'Tweeter',
        'series': twitterArray
      }
    ];
  }

}
