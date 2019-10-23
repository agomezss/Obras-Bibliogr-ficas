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
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
require("rxjs/add/operator/map");
var AutorService = /** @class */ (function () {
    function AutorService(http) {
        this.http = http;
    }
    AutorService.prototype.add = function (obj) {
        var uri = 'http://localhost:58754/api/autor';
        this
            .http
            .post(uri, obj)
            .subscribe(function (res) {
            return console.log(res);
        });
    };
    AutorService.prototype.get = function () {
        var uri = 'http://localhost:58754/api/autor';
        return this
            .http
            .get(uri)
            .map(function (res) {
            console.log(res);
            return res;
        });
    };
    AutorService.prototype.edit = function (id) {
        var uri = 'http://localhost:58754/api/autor/' + id;
        return this
            .http
            .get(uri)
            .map(function (res) {
            return res;
        });
    };
    AutorService.prototype.update = function (obj, id) {
        var uri = 'http://localhost:58754/api/autor/' + id;
        this
            .http
            .put(uri, obj)
            .subscribe(function (res) { return console.log(res); });
    };
    AutorService.prototype.delete = function (id) {
        var uri = 'http://localhost:58754/api/autor/' + id;
        return this
            .http
            .delete(uri)
            .map(function (res) {
            return res;
        });
    };
    AutorService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], AutorService);
    return AutorService;
}());
exports.AutorService = AutorService;
//# sourceMappingURL=autor.service.js.map