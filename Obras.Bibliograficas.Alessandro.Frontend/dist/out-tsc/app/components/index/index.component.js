"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var autor_service_1 = require("../../autor.service");
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var IndexComponent = /** @class */ (function () {
    function IndexComponent(http, service) {
        this.http = http;
        this.service = service;
    }
    IndexComponent.prototype.ngOnInit = function () {
        this.getAutores();
    };
    IndexComponent.prototype.ngAfterViewInit = function () {
        this.getAutores();
    };
    IndexComponent.prototype.getAutores = function () {
        var _this = this;
        this.service.get().subscribe(function (res) {
            _this.autores = res;
        });
    };
    IndexComponent = __decorate([
        core_1.Component({
            selector: 'app-index',
            templateUrl: './index.component.html',
            styleUrls: ['./index.component.css']
        }),
        __metadata("design:paramtypes", [http_1.HttpClient, autor_service_1.AutorService])
    ], IndexComponent);
    return IndexComponent;
}());
exports.IndexComponent = IndexComponent;
//# sourceMappingURL=index.component.js.map