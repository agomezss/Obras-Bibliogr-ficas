"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var http_1 = require("@angular/common/http");
var forms_1 = require("@angular/forms");
var app_component_1 = require("./app.component");
var index_component_1 = require("./components/index/index.component");
var create_component_1 = require("./components/create/create.component");
var edit_component_1 = require("./components/edit/edit.component");
var routerConfig_1 = require("./routerConfig");
var autor_service_1 = require("./autor.service");
var forms_2 = require("@angular/forms");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                index_component_1.IndexComponent,
                create_component_1.CreateComponent,
                edit_component_1.EditComponent
            ],
            imports: [
                platform_browser_1.BrowserModule, router_1.RouterModule.forRoot(routerConfig_1.appRoutes), http_1.HttpClientModule, forms_1.ReactiveFormsModule, forms_2.FormsModule
            ],
            providers: [autor_service_1.AutorService],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map