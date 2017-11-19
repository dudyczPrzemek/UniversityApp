import { ChartModel } from './../../models/chart/chart.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-activity-analizer',
  templateUrl: './activity-analizer.component.html',
  styleUrls: ['./activity-analizer.component.scss']
})
export class ActivityAnalizerComponent implements OnInit {
  public hashtagChartModel: ChartModel;
  public hourActivityChart: ChartModel;

  constructor() { }

  ngOnInit() {
    this.initHashtagChartModel();
    this.initHourActivityChart();
  }

  private initHashtagChartModel() {
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
    this.hashtagChartModel.data = [
      {
        'name': 'polishboy',
        'value': 15
      },
      {
        'name': 'polishgirl',
        'value': 8
      },
      {
        'name': 'sport',
        'value': 5
      }
    ];
  }

  private initHourActivityChart() {
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
        'name': 'Facebook',
        'series': [
          {'name': '00:00', 'value': 19}, {'name': '01:00', 'value': 0},
          {'name': '02:00', 'value': 0}, {'name': '03:00', 'value': 0},
          {'name': '04:00', 'value': 0}, {'name': '05:00', 'value': 0},
          {'name': '06:00', 'value': 0}, {'name': '07:00', 'value': 1},
          {'name': '08:00', 'value': 0}, {'name': '09:00', 'value': 1},
          {'name': '10:00', 'value': 3}, {'name': '11:00', 'value': 3},
          {'name': '12:00', 'value': 3}, {'name': '13:00', 'value': 3},
          {'name': '14:00', 'value': 6}, {'name': '15:00', 'value': 12},
          {'name': '16:00', 'value': 20}, {'name': '17:00', 'value': 25},
          {'name': '18:00', 'value': 30}, {'name': '19:00', 'value': 40},
          {'name': '20:00', 'value': 34}, {'name': '21:00', 'value': 34},
          {'name': '22:00', 'value': 25}, {'name': '23:00', 'value': 20}
        ]
      },
      {
        'name': 'Instagram',
        'series': [
          {'name': '00:00', 'value': 19}, {'name': '01:00', 'value': 5},
          {'name': '02:00', 'value': 0}, {'name': '03:00', 'value': 0},
          {'name': '04:00', 'value': 0}, {'name': '05:00', 'value': 0},
          {'name': '06:00', 'value': 0}, {'name': '07:00', 'value': 0},
          {'name': '08:00', 'value': 0}, {'name': '09:00', 'value': 0},
          {'name': '10:00', 'value': 1}, {'name': '11:00', 'value': 4},
          {'name': '12:00', 'value': 3}, {'name': '13:00', 'value': 7},
          {'name': '14:00', 'value': 8}, {'name': '15:00', 'value': 7},
          {'name': '16:00', 'value': 11}, {'name': '17:00', 'value': 25},
          {'name': '18:00', 'value': 29}, {'name': '19:00', 'value': 32},
          {'name': '20:00', 'value': 50}, {'name': '21:00', 'value': 48},
          {'name': '22:00', 'value': 45}, {'name': '23:00', 'value': 47}
        ]
      },
      {
        'name': 'Tweeter',
        'series': [
          {'name': '00:00', 'value': 4}, {'name': '01:00', 'value': 2},
          {'name': '02:00', 'value': 0}, {'name': '03:00', 'value': 0},
          {'name': '04:00', 'value': 0}, {'name': '05:00', 'value': 0},
          {'name': '06:00', 'value': 0}, {'name': '07:00', 'value': 0},
          {'name': '08:00', 'value': 0}, {'name': '09:00', 'value': 0},
          {'name': '10:00', 'value': 0}, {'name': '11:00', 'value': 0},
          {'name': '12:00', 'value': 1}, {'name': '13:00', 'value': 1},
          {'name': '14:00', 'value': 2}, {'name': '15:00', 'value': 1},
          {'name': '16:00', 'value': 4}, {'name': '17:00', 'value': 5},
          {'name': '18:00', 'value': 1}, {'name': '19:00', 'value': 3},
          {'name': '20:00', 'value': 10}, {'name': '21:00', 'value': 6},
          {'name': '22:00', 'value': 6}, {'name': '23:00', 'value': 7}
        ]
      }
    ];
  }

}
