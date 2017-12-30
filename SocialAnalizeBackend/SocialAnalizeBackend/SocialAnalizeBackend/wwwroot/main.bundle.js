webpackJsonp(["main"],{

/***/ "../../../../../src/$$_gendir lazy recursive":
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncatched exception popping up in devtools
	return Promise.resolve().then(function() {
		throw new Error("Cannot find module '" + req + "'.");
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "../../../../../src/$$_gendir lazy recursive";

/***/ }),

/***/ "../../../../../src/app/app.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* unused harmony export appInitializeFactory */
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppModule; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_http__ = __webpack_require__("../../../http/@angular/http.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common_http__ = __webpack_require__("../../../common/@angular/common/http.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__components_character_analizer_character_analizer_component__ = __webpack_require__("../../../../../src/app/components/character-analizer/character-analizer.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__components_activity_analizer_activity_analizer_component__ = __webpack_require__("../../../../../src/app/components/activity-analizer/activity-analizer.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__components_location_analizer_location_analizer_component__ = __webpack_require__("../../../../../src/app/components/location-analizer/location-analizer.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__components_personal_data_personal_data_component__ = __webpack_require__("../../../../../src/app/components/personal-data/personal-data.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__components_add_start_page_add_start_page_component__ = __webpack_require__("../../../../../src/app/components/add-start-page/add-start-page.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__components_top_navigation_top_navigation_component__ = __webpack_require__("../../../../../src/app/components/top-navigation/top-navigation.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__services_authentication_authentication_service__ = __webpack_require__("../../../../../src/app/services/authentication/authentication.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_9__components_side_navigation_side_navigation_component__ = __webpack_require__("../../../../../src/app/components/side-navigation/side-navigation.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_10__components_dashboard_dashboard_component__ = __webpack_require__("../../../../../src/app/components/dashboard/dashboard.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_11__app_routing_module__ = __webpack_require__("../../../../../src/app/app.routing.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_12__angular_platform_browser__ = __webpack_require__("../../../platform-browser/@angular/platform-browser.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_13__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_14__angular_material__ = __webpack_require__("../../../material/esm5/material.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_15__agm_core__ = __webpack_require__("../../../../@agm/core/index.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_16__swimlane_ngx_charts__ = __webpack_require__("../../../../@swimlane/ngx-charts/release/index.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_16__swimlane_ngx_charts___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_16__swimlane_ngx_charts__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_17__components_app_app_component__ = __webpack_require__("../../../../../src/app/components/app/app.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_18__components_authentication_authentication_component__ = __webpack_require__("../../../../../src/app/components/authentication/authentication.component.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = y[op[0] & 2 ? "return" : op[0] ? "throw" : "next"]) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [0, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};



















function appInitializeFactory(iconRegistry) {
    var _this = this;
    return function () { return __awaiter(_this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            iconRegistry.registerDefaultSvgIcons();
            return [2 /*return*/];
        });
    }); };
}
var AppModule = (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_13__angular_core__["NgModule"])({
            declarations: [
                __WEBPACK_IMPORTED_MODULE_17__components_app_app_component__["a" /* AppComponent */],
                __WEBPACK_IMPORTED_MODULE_18__components_authentication_authentication_component__["a" /* AuthenticationComponent */],
                __WEBPACK_IMPORTED_MODULE_10__components_dashboard_dashboard_component__["a" /* DashboardComponent */],
                __WEBPACK_IMPORTED_MODULE_9__components_side_navigation_side_navigation_component__["a" /* SideNavigationComponent */],
                __WEBPACK_IMPORTED_MODULE_7__components_top_navigation_top_navigation_component__["a" /* TopNavigationComponent */],
                __WEBPACK_IMPORTED_MODULE_6__components_add_start_page_add_start_page_component__["a" /* AddStartPageComponent */],
                __WEBPACK_IMPORTED_MODULE_5__components_personal_data_personal_data_component__["a" /* PersonalDataComponent */],
                __WEBPACK_IMPORTED_MODULE_4__components_location_analizer_location_analizer_component__["a" /* LocationAnalizerComponent */],
                __WEBPACK_IMPORTED_MODULE_3__components_activity_analizer_activity_analizer_component__["a" /* ActivityAnalizerComponent */],
                __WEBPACK_IMPORTED_MODULE_2__components_character_analizer_character_analizer_component__["a" /* CharacterAnalizerComponent */]
            ],
            imports: [
                __WEBPACK_IMPORTED_MODULE_12__angular_platform_browser__["BrowserModule"],
                __WEBPACK_IMPORTED_MODULE_11__app_routing_module__["a" /* AppRoutingModule */],
                __WEBPACK_IMPORTED_MODULE_14__angular_material__["a" /* MatIconModule */],
                __WEBPACK_IMPORTED_MODULE_15__agm_core__["a" /* AgmCoreModule */].forRoot({
                    apiKey: 'AIzaSyBr3iyBE5CDyJGhg5qJNaXEXJgtqRzY0bg'
                }),
                __WEBPACK_IMPORTED_MODULE_16__swimlane_ngx_charts__["NgxChartsModule"],
                __WEBPACK_IMPORTED_MODULE_1__angular_common_http__["b" /* HttpClientModule */],
                __WEBPACK_IMPORTED_MODULE_0__angular_http__["b" /* HttpModule */]
            ],
            providers: [
                __WEBPACK_IMPORTED_MODULE_8__services_authentication_authentication_service__["a" /* AuthenticationService */]
            ],
            bootstrap: [__WEBPACK_IMPORTED_MODULE_17__components_app_app_component__["a" /* AppComponent */]]
        })
    ], AppModule);
    return AppModule;
}());

//# sourceMappingURL=app.module.js.map

/***/ }),

/***/ "../../../../../src/app/app.routing.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppRoutingModule; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__components_character_analizer_character_analizer_component__ = __webpack_require__("../../../../../src/app/components/character-analizer/character-analizer.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__components_activity_analizer_activity_analizer_component__ = __webpack_require__("../../../../../src/app/components/activity-analizer/activity-analizer.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__components_location_analizer_location_analizer_component__ = __webpack_require__("../../../../../src/app/components/location-analizer/location-analizer.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__components_personal_data_personal_data_component__ = __webpack_require__("../../../../../src/app/components/personal-data/personal-data.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__components_add_start_page_add_start_page_component__ = __webpack_require__("../../../../../src/app/components/add-start-page/add-start-page.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__components_dashboard_dashboard_component__ = __webpack_require__("../../../../../src/app/components/dashboard/dashboard.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__components_authentication_authentication_component__ = __webpack_require__("../../../../../src/app/components/authentication/authentication.component.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};









var routes = [
    { path: '', redirectTo: 'login', pathMatch: 'full' },
    { path: 'login', component: __WEBPACK_IMPORTED_MODULE_8__components_authentication_authentication_component__["a" /* AuthenticationComponent */] },
    { path: 'dashboard', component: __WEBPACK_IMPORTED_MODULE_5__components_dashboard_dashboard_component__["a" /* DashboardComponent */] },
    { path: 'addpage', component: __WEBPACK_IMPORTED_MODULE_4__components_add_start_page_add_start_page_component__["a" /* AddStartPageComponent */] },
    { path: 'pesronaldata', component: __WEBPACK_IMPORTED_MODULE_3__components_personal_data_personal_data_component__["a" /* PersonalDataComponent */] },
    { path: 'locationanalizer', component: __WEBPACK_IMPORTED_MODULE_2__components_location_analizer_location_analizer_component__["a" /* LocationAnalizerComponent */] },
    { path: 'activityanalizer', component: __WEBPACK_IMPORTED_MODULE_1__components_activity_analizer_activity_analizer_component__["a" /* ActivityAnalizerComponent */] },
    { path: 'characteranalizer', component: __WEBPACK_IMPORTED_MODULE_0__components_character_analizer_character_analizer_component__["a" /* CharacterAnalizerComponent */] },
    { path: '**', redirectTo: 'login' }
];
var AppRoutingModule = (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_7__angular_core__["NgModule"])({
            imports: [__WEBPACK_IMPORTED_MODULE_6__angular_router__["c" /* RouterModule */].forRoot(routes)],
            exports: [__WEBPACK_IMPORTED_MODULE_6__angular_router__["c" /* RouterModule */]]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());

//# sourceMappingURL=app.routing.module.js.map

/***/ }),

/***/ "../../../../../src/app/components/activity-analizer/activity-analizer.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"activity-root\">\n  <div class=\"activity-header-container\">\n    <span class=\"activity-header\">Internet activity analizer</span>\n  </div>\n  <div class=\"activity-content\">\n    <div class=\"hashtags-chart\">\n      <label class=\"hashtags-chart-header\">Hashtags of user:</label>\n      <ngx-charts-bar-vertical\n        [view]=\"hashtagChartModel.view\"\n        [scheme]=\"hashtagChartModel.colorScheme\"\n        [results]=\"hashtagChartModel.data\"\n        [gradient]=\"hashtagChartModel.gradient\"\n        [xAxis]=\"hashtagChartModel.showXAxis\"\n        [yAxis]=\"hashtagChartModel.showYAxis\"\n        [legend]=\"hashtagChartModel.showLegend\"\n        [showXAxisLabel]=\"hashtagChartModel.showXAxisLabel\"\n        [showYAxisLabel]=\"hashtagChartModel.showYAxisLabel\"\n        [xAxisLabel]=\"hashtagChartModel.xAxisLabel\"\n        [yAxisLabel]=\"hashtagChartModel.yAxisLabel\">\n      </ngx-charts-bar-vertical>\n    </div>\n    <div class=\"hours-activity-chart\">\n      <label class=\"hours-activity-chart\">Activity during day:</label>\n      <ngx-charts-line-chart\n        [view]=\"hourActivityChart.view\"\n        [scheme]=\"hourActivityChart.colorScheme\"\n        [results]=\"hourActivityChart.data\"\n        [gradient]=\"hourActivityChart.gradient\"\n        [xAxis]=\"hourActivityChart.showXAxis\"\n        [yAxis]=\"hourActivityChart.showYAxis\"\n        [legend]=\"hourActivityChart.showLegend\"\n        [showXAxisLabel]=\"hourActivityChart.showXAxisLabel\"\n        [showYAxisLabel]=\"hourActivityChart.showYAxisLabel\"\n        [xAxisLabel]=\"hourActivityChart.xAxisLabel\"\n        [yAxisLabel]=\"hourActivityChart.yAxisLabel\"\n        [autoScale]=\"hourActivityChart.autoScale\">\n      </ngx-charts-line-chart>\n    </div>\n  </div>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/activity-analizer/activity-analizer.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".activity-root {\n  padding: 1em; }\n\n.activity-content {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column; }\n\n.activity-header {\n  font-size: 2em;\n  font-weight: bold; }\n\n.activity-header-container {\n  padding-bottom: 2em; }\n\n/deep/ .legend-label-text {\n  color: #000000; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/activity-analizer/activity-analizer.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ActivityAnalizerComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__models_chart_chart_model__ = __webpack_require__("../../../../../src/app/models/chart/chart.model.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var ActivityAnalizerComponent = (function () {
    function ActivityAnalizerComponent() {
    }
    ActivityAnalizerComponent.prototype.ngOnInit = function () {
        this.initHashtagChartModel();
        this.initHourActivityChart();
    };
    ActivityAnalizerComponent.prototype.initHashtagChartModel = function () {
        this.hashtagChartModel = new __WEBPACK_IMPORTED_MODULE_0__models_chart_chart_model__["a" /* ChartModel */]();
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
    };
    ActivityAnalizerComponent.prototype.initHourActivityChart = function () {
        this.hourActivityChart = new __WEBPACK_IMPORTED_MODULE_0__models_chart_chart_model__["a" /* ChartModel */]();
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
                    { 'name': '00:00', 'value': 19 }, { 'name': '01:00', 'value': 0 },
                    { 'name': '02:00', 'value': 0 }, { 'name': '03:00', 'value': 0 },
                    { 'name': '04:00', 'value': 0 }, { 'name': '05:00', 'value': 0 },
                    { 'name': '06:00', 'value': 0 }, { 'name': '07:00', 'value': 1 },
                    { 'name': '08:00', 'value': 0 }, { 'name': '09:00', 'value': 1 },
                    { 'name': '10:00', 'value': 3 }, { 'name': '11:00', 'value': 3 },
                    { 'name': '12:00', 'value': 3 }, { 'name': '13:00', 'value': 3 },
                    { 'name': '14:00', 'value': 6 }, { 'name': '15:00', 'value': 12 },
                    { 'name': '16:00', 'value': 20 }, { 'name': '17:00', 'value': 25 },
                    { 'name': '18:00', 'value': 30 }, { 'name': '19:00', 'value': 40 },
                    { 'name': '20:00', 'value': 34 }, { 'name': '21:00', 'value': 34 },
                    { 'name': '22:00', 'value': 25 }, { 'name': '23:00', 'value': 20 }
                ]
            },
            {
                'name': 'Instagram',
                'series': [
                    { 'name': '00:00', 'value': 19 }, { 'name': '01:00', 'value': 5 },
                    { 'name': '02:00', 'value': 0 }, { 'name': '03:00', 'value': 0 },
                    { 'name': '04:00', 'value': 0 }, { 'name': '05:00', 'value': 0 },
                    { 'name': '06:00', 'value': 0 }, { 'name': '07:00', 'value': 0 },
                    { 'name': '08:00', 'value': 0 }, { 'name': '09:00', 'value': 0 },
                    { 'name': '10:00', 'value': 1 }, { 'name': '11:00', 'value': 4 },
                    { 'name': '12:00', 'value': 3 }, { 'name': '13:00', 'value': 7 },
                    { 'name': '14:00', 'value': 8 }, { 'name': '15:00', 'value': 7 },
                    { 'name': '16:00', 'value': 11 }, { 'name': '17:00', 'value': 25 },
                    { 'name': '18:00', 'value': 29 }, { 'name': '19:00', 'value': 32 },
                    { 'name': '20:00', 'value': 50 }, { 'name': '21:00', 'value': 48 },
                    { 'name': '22:00', 'value': 45 }, { 'name': '23:00', 'value': 47 }
                ]
            },
            {
                'name': 'Tweeter',
                'series': [
                    { 'name': '00:00', 'value': 4 }, { 'name': '01:00', 'value': 2 },
                    { 'name': '02:00', 'value': 0 }, { 'name': '03:00', 'value': 0 },
                    { 'name': '04:00', 'value': 0 }, { 'name': '05:00', 'value': 0 },
                    { 'name': '06:00', 'value': 0 }, { 'name': '07:00', 'value': 0 },
                    { 'name': '08:00', 'value': 0 }, { 'name': '09:00', 'value': 0 },
                    { 'name': '10:00', 'value': 0 }, { 'name': '11:00', 'value': 0 },
                    { 'name': '12:00', 'value': 1 }, { 'name': '13:00', 'value': 1 },
                    { 'name': '14:00', 'value': 2 }, { 'name': '15:00', 'value': 1 },
                    { 'name': '16:00', 'value': 4 }, { 'name': '17:00', 'value': 5 },
                    { 'name': '18:00', 'value': 1 }, { 'name': '19:00', 'value': 3 },
                    { 'name': '20:00', 'value': 10 }, { 'name': '21:00', 'value': 6 },
                    { 'name': '22:00', 'value': 6 }, { 'name': '23:00', 'value': 7 }
                ]
            }
        ];
    };
    ActivityAnalizerComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_1__angular_core__["Component"])({
            selector: 'app-activity-analizer',
            template: __webpack_require__("../../../../../src/app/components/activity-analizer/activity-analizer.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/activity-analizer/activity-analizer.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], ActivityAnalizerComponent);
    return ActivityAnalizerComponent;
}());

//# sourceMappingURL=activity-analizer.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/add-start-page/add-start-page.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"add-page-root\">\n  <span class=\"add-text\">Add followed user</span>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/add-start-page/add-start-page.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".add-page-root {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center;\n  width: 100%;\n  height: 100%; }\n\n.add-text {\n  font-size: 4em; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/add-start-page/add-start-page.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AddStartPageComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var AddStartPageComponent = (function () {
    function AddStartPageComponent() {
    }
    AddStartPageComponent.prototype.ngOnInit = function () {
    };
    AddStartPageComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
            selector: 'app-add-start-page',
            template: __webpack_require__("../../../../../src/app/components/add-start-page/add-start-page.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/add-start-page/add-start-page.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], AddStartPageComponent);
    return AddStartPageComponent;
}());

//# sourceMappingURL=add-start-page.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/app/app.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"root\">\r\n    <app-top-navigation class=\"top-navbar\" *ngIf=\"isLogged\"></app-top-navigation>\r\n    <div class=\"root-content\">\r\n        <app-side-navigation class=\"side-navbar\" *ngIf=\"isLogged\"></app-side-navigation>\r\n        <div class=\"content\" [class.full-size]=\"!isLogged\">\r\n            <router-outlet></router-outlet>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/app/app.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".full-size {\n  position: absolute;\n  width: 100%;\n  height: 100%;\n  overflow-y: hidden; }\n\n.root {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  position: absolute;\n  width: 100%;\n  height: 100%;\n  overflow-y: hidden; }\n\n.root-content {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: horizontal;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: row;\n          flex-direction: row;\n  -webkit-box-flex: 1;\n      -ms-flex: 1 100%;\n          flex: 1 100%; }\n\n.top-navbar {\n  background-color: #000000;\n  -webkit-box-flex: 1;\n      -ms-flex: 1 6%;\n          flex: 1 6%; }\n\n.side-navbar {\n  background-color: #000000;\n  -webkit-box-flex: 1;\n      -ms-flex: 1 15%;\n          flex: 1 15%; }\n\n.content {\n  background-color: #C7C2C2;\n  -webkit-box-flex: 1;\n      -ms-flex: 1 85%;\n          flex: 1 85%; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/app/app.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__services_authentication_authentication_service__ = __webpack_require__("../../../../../src/app/services/authentication/authentication.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var AppComponent = (function () {
    function AppComponent(service) {
        this.service = service;
        this.title = 'SocialAnalize';
        this.isLogged = service.isLogged.getValue();
    }
    AppComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.service.isLogged.subscribe(function (isLogged) {
            _this.isLogged = isLogged;
        });
    };
    AppComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_1__angular_core__["Component"])({
            selector: 'app-root',
            template: __webpack_require__("../../../../../src/app/components/app/app.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/app/app.component.scss")]
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_0__services_authentication_authentication_service__["a" /* AuthenticationService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_0__services_authentication_authentication_service__["a" /* AuthenticationService */]) === "function" && _a || Object])
    ], AppComponent);
    return AppComponent;
    var _a;
}());

//# sourceMappingURL=app.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/authentication/authentication.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"container login-page\">\n    <div class=\"login-content\">\n        <div class=\"header-container\">\n            <h1 class=\"login-header\">Welcome to</h1>\n            <h1 class=\"login-header login-app-name\">Social Analizer</h1>\n        </div>\n        <div class=\"login-buttons\">\n            <div class=\"login-button-container\">\n                <button\n                    type=\"button\" \n                    class=\"btn btn-primary login-button\"\n                    (click)=\"useFacebookClick()\"\n                >\n                    Use Facebook\n                </button>\n            </div>\n            <div class=\"login-button-container\">\n                <button\n                     type=\"button\" \n                     class=\"btn btn-primary login-button\"\n                     (click)=\"useInstagramClick()\"\n                >\n                    Use Instagram\n                </button>\n            </div>\n            <div class=\"login-button-container\">\n                <button \n                    type=\"button\" \n                    class=\"btn btn-primary login-button\"\n                    (click)=\"useTweeterClick()\"\n                >\n                    Use Tweeter\n                </button>\n            </div>\n        </div>\n    </div>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/authentication/authentication.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".login-page {\n  background: url(" + __webpack_require__("../../../../../src/assets/images/loginBackground.jpg") + ") no-repeat center center fixed;\n  background-size: cover;\n  height: 100%;\n  width: 100%;\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center; }\n\n.login-content {\n  background-color: rgba(0, 0, 0, 0.5);\n  border-radius: 25px; }\n\n.header-container {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center;\n  padding: 2em; }\n\n.login-header {\n  font-size: 3em;\n  color: #ffffff; }\n\n.login-app-name {\n  font-size: 4em; }\n\n.login-buttons {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center;\n  padding: 2em; }\n\n.login-button {\n  width: 20em; }\n\n.login-button-container {\n  padding-bottom: 1em; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/authentication/authentication.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AuthenticationComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__services_authentication_authentication_service__ = __webpack_require__("../../../../../src/app/services/authentication/authentication.service.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var AuthenticationComponent = (function () {
    function AuthenticationComponent(router, route, service) {
        this.router = router;
        this.route = route;
        this.service = service;
    }
    AuthenticationComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.queryParams.subscribe(function (params) {
            var facebookAccessToken = params['facebookAccessToken'];
            var instagramAccessToken = params['instagramAccessToken'];
            var twitterAccessToken = params['twitterAccessToken'];
            if (facebookAccessToken) {
                _this.service.loginUser('facebookAccessToken', facebookAccessToken);
                _this.router.navigate(['addpage']);
            }
            if (instagramAccessToken) {
                _this.service.loginUser('instagramAccessToken', instagramAccessToken);
                _this.router.navigate(['addpage']);
            }
            if (twitterAccessToken) {
                _this.service.loginUser('twitterAccessToken', twitterAccessToken);
                _this.router.navigate(['addpage']);
            }
        });
    };
    AuthenticationComponent.prototype.useFacebookClick = function () {
        this.service.loginFacebookUser();
    };
    AuthenticationComponent.prototype.useInstagramClick = function () {
        this.service.loginInstagramUser();
    };
    AuthenticationComponent.prototype.useTweeterClick = function () {
        this.service.loginTwitterUser();
    };
    AuthenticationComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_2__angular_core__["Component"])({
            selector: 'app-authentication',
            template: __webpack_require__("../../../../../src/app/components/authentication/authentication.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/authentication/authentication.component.scss")]
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* Router */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* ActivatedRoute */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* ActivatedRoute */]) === "function" && _b || Object, typeof (_c = typeof __WEBPACK_IMPORTED_MODULE_0__services_authentication_authentication_service__["a" /* AuthenticationService */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_0__services_authentication_authentication_service__["a" /* AuthenticationService */]) === "function" && _c || Object])
    ], AuthenticationComponent);
    return AuthenticationComponent;
    var _a, _b, _c;
}());

//# sourceMappingURL=authentication.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/character-analizer/character-analizer.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"character-root\">\n  <div class=\"character-header\">\n    <span class=\"character-header-content\">Character analizer</span>\n  </div>\n  <div class=\"character-content\">\n    <div class=\"sentiment-chart\">\n        <label class=\"sentiment-chart-header\">Sentiment of user opinions:</label>\n        <ngx-charts-bar-vertical\n          [view]=\"sentimentChartModel.view\"\n          [scheme]=\"sentimentChartModel.colorScheme\"\n          [results]=\"sentimentChartModel.data\"\n          [gradient]=\"sentimentChartModel.gradient\"\n          [xAxis]=\"sentimentChartModel.showXAxis\"\n          [yAxis]=\"sentimentChartModel.showYAxis\"\n          [legend]=\"sentimentChartModel.showLegend\"\n          [showXAxisLabel]=\"sentimentChartModel.showXAxisLabel\"\n          [showYAxisLabel]=\"sentimentChartModel.showYAxisLabel\"\n          [xAxisLabel]=\"sentimentChartModel.xAxisLabel\"\n          [yAxisLabel]=\"sentimentChartModel.yAxisLabel\">\n        </ngx-charts-bar-vertical>\n    </div>\n  </div>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/character-analizer/character-analizer.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".character-root {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  padding: 2em; }\n\n.character-header {\n  padding-bottom: 1em; }\n\n.character-header-content {\n  font-size: 2em;\n  font-weight: bold; }\n\n/deep/ .legend-label-text {\n  color: #000000; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/character-analizer/character-analizer.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return CharacterAnalizerComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__models_chart_chart_model__ = __webpack_require__("../../../../../src/app/models/chart/chart.model.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var CharacterAnalizerComponent = (function () {
    function CharacterAnalizerComponent() {
        this.initSentimentChartModel();
    }
    CharacterAnalizerComponent.prototype.ngOnInit = function () {
    };
    CharacterAnalizerComponent.prototype.initSentimentChartModel = function () {
        this.sentimentChartModel = new __WEBPACK_IMPORTED_MODULE_0__models_chart_chart_model__["a" /* ChartModel */]();
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
    };
    CharacterAnalizerComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_1__angular_core__["Component"])({
            selector: 'app-character-analizer',
            template: __webpack_require__("../../../../../src/app/components/character-analizer/character-analizer.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/character-analizer/character-analizer.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], CharacterAnalizerComponent);
    return CharacterAnalizerComponent;
}());

//# sourceMappingURL=character-analizer.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/dashboard/dashboard.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"dashboard-root\">\n  <div class=\"data-row\">\n    <div class=\"user-data\">\n      <img class=\"user-icon-circle\" src=\"../../../assets/images/unknowPerson.jpg\"/>\n      <div class=\"user-name\">Bill Gates</div>\n    </div>\n    <div class=\"social-page\">\n      <button class=\"data-btn\">Use Facebook</button>\n      <button class=\"data-btn\">Use Instagram</button>\n      <button class=\"data-btn\">Use Tweeter</button>\n    </div>\n  </div>\n  <div class=\"data-row\">\n    <div class=\"personal-data analize-rect\">\n      <button class=\"data-btn btn-primary\">Personal Data</button>\n    </div>\n    <div class=\"location-analizer analize-rect\">\n      <button class=\"data-btn data-btn btn-primary\">Location Analizer</button>\n    </div>\n  </div>\n  <div class=\"data-row\">\n    <div class=\"activity-analizer analize-rect\">\n      <button class=\"data-btn data-btn btn-primary\">Internet Activity Analizer</button>\n    </div>\n    <div class=\"character-analizer analize-rect\">\n      <button class=\"data-btn data-btn btn-primary\">Character Analizer</button>\n    </div>\n  </div>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/dashboard/dashboard.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".dashboard-root {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  padding: 2em; }\n\n.data-row {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: horizontal;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: row;\n          flex-direction: row;\n  -webkit-box-pack: justify;\n      -ms-flex-pack: justify;\n          justify-content: space-between;\n  padding-bottom: 2em;\n  -webkit-box-flex: 1;\n      -ms-flex: 1 33%;\n          flex: 1 33%; }\n\n/*User icon and name*/\n.user-data {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center;\n  -webkit-box-flex: 0;\n      -ms-flex: 0 40%;\n          flex: 0 40%; }\n\n.user-icon-circle {\n  height: 10em;\n  width: 10em;\n  border-radius: 50%; }\n\n.user-name {\n  font-size: 3em; }\n\n/*Social page */\n.social-page {\n  -webkit-box-flex: 0;\n      -ms-flex: 0 40%;\n          flex: 0 40%;\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center;\n  background-color: #B5B8B9; }\n\n/*Analizing buttons*/\n.analize-rect {\n  -webkit-box-flex: 0;\n      -ms-flex: 0 40%;\n          flex: 0 40%;\n  height: 10em;\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center; }\n\n.personal-data {\n  background-color: #B5B8B9; }\n\n.location-analizer {\n  background-color: #B5B8B9; }\n\n.activity-analizer {\n  background-color: #B5B8B9; }\n\n.character-analizer {\n  background-color: #B5B8B9; }\n\n.data-btn {\n  width: 20em; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/dashboard/dashboard.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return DashboardComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var DashboardComponent = (function () {
    function DashboardComponent(route, router) {
        this.route = route;
        this.router = router;
    }
    DashboardComponent.prototype.ngOnInit = function () {
    };
    DashboardComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
            selector: 'app-dashboard',
            template: __webpack_require__("../../../../../src/app/components/dashboard/dashboard.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/dashboard/dashboard.component.scss")]
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* ActivatedRoute */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["a" /* ActivatedRoute */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_router__["b" /* Router */]) === "function" && _b || Object])
    ], DashboardComponent);
    return DashboardComponent;
    var _a, _b;
}());

//# sourceMappingURL=dashboard.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/location-analizer/location-analizer.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"location-root\">\n  <div class=\"location-header\">\n    <span class=\"location-header-content\">Location analizer</span>\n  </div>\n  <div class=\"location-content\">\n    <div class=\"location-data\">\n      <div class=\"user-data\">\n        <div>\n          <label>Name:</label>\n          <span>Bill Gates</span>\n        </div>\n        <div>\n          <label>Hometown:</label>\n          <span>Los Angeles</span>\n        </div>\n        <div>\n          <label>Current town:</label>\n          <span>Los Angeles</span>\n        </div>\n      </div>\n    </div>\n    <div class=\"map\">\n      <label class=\"map-label\">User localization history:</label>\n      <agm-map [latitude]=\"lat\" [longitude]=\"lng\">\n        <agm-marker [latitude]=\"lat\" [longitude]=\"lng\"></agm-marker>\n      </agm-map>\n    </div>\n  </div>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/location-analizer/location-analizer.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".location-root {\n  padding: 1em; }\n\nagm-map {\n  height: 350px;\n  width: 100%; }\n\n.location-content {\n  font-size: 1.4em; }\n\n.location-header {\n  padding-bottom: 1em; }\n\n.location-header-content {\n  font-size: 2em;\n  font-weight: bold; }\n\n.location-data {\n  padding-bottom: 2em; }\n\n.map-label {\n  padding-bottom: 0.5em; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/location-analizer/location-analizer.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return LocationAnalizerComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var LocationAnalizerComponent = (function () {
    function LocationAnalizerComponent() {
        this.lat = 51.1079;
        this.lng = 17.0385;
    }
    LocationAnalizerComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
            selector: 'app-location-analizer',
            template: __webpack_require__("../../../../../src/app/components/location-analizer/location-analizer.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/location-analizer/location-analizer.component.scss")]
        })
    ], LocationAnalizerComponent);
    return LocationAnalizerComponent;
}());

//# sourceMappingURL=location-analizer.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/personal-data/personal-data.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"personal-root\">\n  <div class=\"personal-header\">\n    <span class=\"personal-header-content\">Personal Data</span>\n  </div>\n  <div class=\"personal-content\">\n    <div class=\"personal-data\">\n      <div>\n        <label>Name: </label>\n        <span>Bill Gates</span>\n      </div>\n      <div>\n        <label>Gender: </label>\n        <span>Male</span>\n      </div>\n      <div>\n        <label>Birthdate: </label>\n        <span>18-12-1994</span>\n      </div>\n      <div>\n        <label>Adress: </label>\n        <span>OC Maryland</span>\n      </div>\n      <div>\n        <label>Email: </label>\n        <span>bill.gates@gmail.com</span>\n      </div>\n    </div>\n    <div class=\"photos\">\n      <label class=\"photos-header\">Photos: </label>\n      <div class=\"photos-content\">\n        <div class=\"photo-row\">\n          <div class=\"photo\">\n            <img src=\"../../../assets/images/unknowPerson.jpg\"/>\n          </div>\n          <div class=\"photo\">\n            <img src=\"../../../assets/images/unknowPerson.jpg\"/>\n          </div>\n          <div class=\"photo\">\n            <img src=\"../../../assets/images/unknowPerson.jpg\"/>\n          </div>\n        </div>\n        <div class=\"photo-row\"> \n          <div class=\"photo\">\n            <img src=\"../../../assets/images/unknowPerson.jpg\"/>\n          </div>\n        </div>\n      </div>\n    </div>\n  </div>\n</div>\n"

/***/ }),

/***/ "../../../../../src/app/components/personal-data/personal-data.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".personal-root {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  padding: 2em; }\n\n.personal-header-content {\n  font-size: 2em;\n  font-weight: bold; }\n\n.personal-data {\n  font-size: 1.2em; }\n\n.photos-header {\n  font-size: 1.2em; }\n\n.photo-content {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  width: 100%;\n  height: 100%; }\n\n.photo-row {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: horizontal;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: row;\n          flex-direction: row; }\n\n.photo {\n  width: 2em;\n  height: 2em; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/personal-data/personal-data.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return PersonalDataComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var PersonalDataComponent = (function () {
    function PersonalDataComponent() {
    }
    PersonalDataComponent.prototype.ngOnInit = function () {
    };
    PersonalDataComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
            selector: 'app-personal-data',
            template: __webpack_require__("../../../../../src/app/components/personal-data/personal-data.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/personal-data/personal-data.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], PersonalDataComponent);
    return PersonalDataComponent;
}());

//# sourceMappingURL=personal-data.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/side-navigation/side-navigation.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"side-navbar-root\">\n  <div class=\"logged-user-info\">\n    <img class=\"logged-icon-circle\" src=\"https://scontent.fwaw5-1.fna.fbcdn.net/v/t1.0-9/1468814_603637589692879_499809455_n.jpg?oh=68eab80d86d416cead9c1a901ab24a80&oe=5AA839B5\"/>\n    <div class=\"user-greeting\">Hello Przemek</div>\n  </div>\n  <div class=\"side-navbar-content\">\n    <div class=\"followed-user-header\">\n        <div>Followed Users</div>\n    </div>\n    <div class=\"followed-user-content\">\n      <div class=\"followed-user\">\n        <div class=\"followed-user-data\">\n          <img class=\"person-icon-circle\" src=\"../../../assets/images/unknowPerson.jpg\"/>\n          <span class=\"person-name clickable\" (click)=\"dashboardClick()\">Bill Gates</span>\n        </div>\n        <div class=\"followed-user-analisys\">\n          <span class=\"analysis-nav clickable\" (click)=\"personalDataClick()\">Personal data</span>\n          <span class=\"analysis-nav clickable\" (click)=\"locationClick()\">Location</span>\n          <span class=\"analysis-nav clickable\" (click)=\"activityClick()\">Internet activity</span>\n          <span class=\"analysis-nav clickable\" (click)=\"characterClick()\">Character</span>\n        </div>\n      </div>\n      <div class=\"followed-user\">\n        <div class=\"followed-user-data\">\n          <img class=\"person-icon-circle\" src=\"../../../assets/images/unknowPerson.jpg\"/>\n          <span class=\"person-name clickable\" (click)=\"dashboardClick()\">Jacek Nowak</span>\n        </div>\n        <div class=\"followed-user-analisys hidden\">\n            <span class=\"analysis-nav clickable\" (click)=\"personalDataClick()\">Personal data</span>\n            <span class=\"analysis-nav clickable\" (click)=\"locationClick()\">Location</span>\n            <span class=\"analysis-nav clickable\" (click)=\"activityClick()\">Internet activity</span>\n            <span class=\"analysis-nav clickable\" (click)=\"characterClick()\">Character</span>\n        </div>\n      </div>\n      <div class=\"followed-user\">\n        <div class=\"followed-user-data\">\n          <img class=\"person-icon-circle\" src=\"../../../assets/images/unknowPerson.jpg\"/>\n          <span class=\"person-name clickable\" (click)=\"dashboardClick()\">Lionel Messi</span>\n        </div>\n        <div class=\"followed-user-analisys hidden\">\n            <span class=\"analysis-nav clickable\" (click)=\"personalDataClick()\">Personal data</span>\n            <span class=\"analysis-nav clickable\" (click)=\"locationClick()\">Location</span>\n            <span class=\"analysis-nav clickable\" (click)=\"activityClick()\">Internet activity</span>\n            <span class=\"analysis-nav clickable\" (click)=\"characterClick()\">Character</span>\n        </div>\n      </div>\n    </div>\n  </div>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/side-navigation/side-navigation.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".side-navbar-root {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  color: #ffffff; }\n\n.logged-user-info {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  -webkit-box-align: center;\n      -ms-flex-align: center;\n          align-items: center;\n  padding-top: 1em;\n  padding-bottom: 2em; }\n\n.user-greeting {\n  padding-top: 1em; }\n\n.logged-icon-circle {\n  height: 5em;\n  width: 5em;\n  border-radius: 50%; }\n\n.followed-user-header {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: horizontal;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: row;\n          flex-direction: row;\n  padding-left: 0.5em;\n  padding-bottom: 1em; }\n\n.followed-user {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  padding-left: 2em;\n  padding-bottom: 1em; }\n\n.person-icon-circle {\n  height: 2.4em;\n  width: 2.4em;\n  border-radius: 50%; }\n\n.person-name {\n  padding-top: 0.5em;\n  padding-left: 1em; }\n\n.followed-user-analisys {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-orient: vertical;\n  -webkit-box-direction: normal;\n      -ms-flex-direction: column;\n          flex-direction: column;\n  padding-left: 2em; }\n\n.analysis-nav {\n  padding-bottom: 0.4em; }\n\n.followed-user-data {\n  padding-bottom: 1em; }\n\n.hidden {\n  display: none; }\n\n.clickable {\n  cursor: pointer; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/side-navigation/side-navigation.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return SideNavigationComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_router__ = __webpack_require__("../../../router/@angular/router.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var SideNavigationComponent = (function () {
    function SideNavigationComponent(router, route) {
        this.router = router;
        this.route = route;
    }
    SideNavigationComponent.prototype.dashboardClick = function () {
        this.router.navigate(['dashboard']);
    };
    SideNavigationComponent.prototype.personalDataClick = function () {
        this.router.navigate(['pesronaldata']);
    };
    SideNavigationComponent.prototype.locationClick = function () {
        this.router.navigate(['locationanalizer']);
    };
    SideNavigationComponent.prototype.activityClick = function () {
        this.router.navigate(['activityanalizer']);
    };
    SideNavigationComponent.prototype.characterClick = function () {
        this.router.navigate(['characteranalizer']);
    };
    SideNavigationComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_1__angular_core__["Component"])({
            selector: 'app-side-navigation',
            template: __webpack_require__("../../../../../src/app/components/side-navigation/side-navigation.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/side-navigation/side-navigation.component.scss")]
        }),
        __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_0__angular_router__["b" /* Router */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_0__angular_router__["b" /* Router */]) === "function" && _a || Object, typeof (_b = typeof __WEBPACK_IMPORTED_MODULE_0__angular_router__["a" /* ActivatedRoute */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_0__angular_router__["a" /* ActivatedRoute */]) === "function" && _b || Object])
    ], SideNavigationComponent);
    return SideNavigationComponent;
    var _a, _b;
}());

//# sourceMappingURL=side-navigation.component.js.map

/***/ }),

/***/ "../../../../../src/app/components/top-navigation/top-navigation.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"top-navbar-root\">\n  <span class=\"top-navbar-content\">Social Analizer</span>\n</div>"

/***/ }),

/***/ "../../../../../src/app/components/top-navigation/top-navigation.component.scss":
/***/ (function(module, exports, __webpack_require__) {

exports = module.exports = __webpack_require__("../../../../css-loader/lib/css-base.js")(false);
// imports


// module
exports.push([module.i, ".top-navbar-root {\n  display: -webkit-box;\n  display: -ms-flexbox;\n  display: flex;\n  -webkit-box-pack: center;\n      -ms-flex-pack: center;\n          justify-content: center; }\n\n.top-navbar-content {\n  color: #ffffff;\n  font-size: 2em; }\n", ""]);

// exports


/*** EXPORTS FROM exports-loader ***/
module.exports = module.exports.toString();

/***/ }),

/***/ "../../../../../src/app/components/top-navigation/top-navigation.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return TopNavigationComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var TopNavigationComponent = (function () {
    function TopNavigationComponent() {
    }
    TopNavigationComponent.prototype.ngOnInit = function () {
    };
    TopNavigationComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Component"])({
            selector: 'app-top-navigation',
            template: __webpack_require__("../../../../../src/app/components/top-navigation/top-navigation.component.html"),
            styles: [__webpack_require__("../../../../../src/app/components/top-navigation/top-navigation.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], TopNavigationComponent);
    return TopNavigationComponent;
}());

//# sourceMappingURL=top-navigation.component.js.map

/***/ }),

/***/ "../../../../../src/app/models/chart/chart.model.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return ChartModel; });
var ChartModel = (function () {
    function ChartModel() {
    }
    return ChartModel;
}());

//# sourceMappingURL=chart.model.js.map

/***/ }),

/***/ "../../../../../src/app/services/authentication/authentication.service.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AuthenticationService; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_common_http__ = __webpack_require__("../../../common/@angular/common/http.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__ = __webpack_require__("../../../../rxjs/BehaviorSubject.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__);
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var AuthenticationService = (function () {
    function AuthenticationService(http) {
        this.http = http;
        this.isLogged = new __WEBPACK_IMPORTED_MODULE_2_rxjs_BehaviorSubject__["BehaviorSubject"](this.isUserLogged());
    }
    AuthenticationService.prototype.isUserLogged = function () {
        var facebookAccessToken = this.getCurrentFacebookAccessToken();
        var instagramAccessToken = this.getCurrentInstagramAccessToken();
        var twitterAccessToken = this.getCurrentTwitterAccessToken();
        return facebookAccessToken !== null || instagramAccessToken !== null || twitterAccessToken !== null;
    };
    AuthenticationService.prototype.loginUser = function (accessToken, socialMediaType) {
        this.isLogged.next(true);
        localStorage.setItem(socialMediaType + "AccessToken", accessToken);
    };
    AuthenticationService.prototype.getCurrentFacebookAccessToken = function () {
        return localStorage.getItem('FacebookAccessToken');
    };
    AuthenticationService.prototype.getCurrentInstagramAccessToken = function () {
        return localStorage.getItem('InstagramAccessToken');
    };
    AuthenticationService.prototype.getCurrentTwitterAccessToken = function () {
        return localStorage.getItem('TwitterAccessToken');
    };
    AuthenticationService.prototype.loginInstagramUser = function () {
        window.location.href = 'http://localhost:50985/api/instagramAuthentication/authenticate';
    };
    AuthenticationService.prototype.loginFacebookUser = function () {
        window.location.href = 'http://localhost:50985/api/facebookAuthentication/authenticate';
    };
    AuthenticationService.prototype.loginTwitterUser = function () {
        window.location.href = 'http://localhost:50985/api/twitterAuthentication/authenticate';
    };
    AuthenticationService = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["Injectable"])(),
        __metadata("design:paramtypes", [typeof (_a = typeof __WEBPACK_IMPORTED_MODULE_1__angular_common_http__["a" /* HttpClient */] !== "undefined" && __WEBPACK_IMPORTED_MODULE_1__angular_common_http__["a" /* HttpClient */]) === "function" && _a || Object])
    ], AuthenticationService);
    return AuthenticationService;
    var _a;
}());

//# sourceMappingURL=authentication.service.js.map

/***/ }),

/***/ "../../../../../src/assets/images/loginBackground.jpg":
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__.p + "loginBackground.a74378c12712ab2233f9.jpg";

/***/ }),

/***/ "../../../../../src/environments/environment.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return environment; });
// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
var environment = {
    production: false
};
//# sourceMappingURL=environment.js.map

/***/ }),

/***/ "../../../../../src/main.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("../../../core/@angular/core.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__ = __webpack_require__("../../../platform-browser-dynamic/@angular/platform-browser-dynamic.es5.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__app_app_module__ = __webpack_require__("../../../../../src/app/app.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__environments_environment__ = __webpack_require__("../../../../../src/environments/environment.ts");




if (__WEBPACK_IMPORTED_MODULE_3__environments_environment__["a" /* environment */].production) {
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["enableProdMode"])();
}
Object(__WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__["a" /* platformBrowserDynamic */])().bootstrapModule(__WEBPACK_IMPORTED_MODULE_2__app_app_module__["a" /* AppModule */])
    .catch(function (err) { return console.log(err); });
//# sourceMappingURL=main.js.map

/***/ }),

/***/ 0:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__("../../../../../src/main.ts");


/***/ })

},[0]);
//# sourceMappingURL=main.bundle.js.map