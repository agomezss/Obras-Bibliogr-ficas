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
var router_1 = require("@angular/router");
var core_1 = require("@angular/core");
var autor_service_1 = require("../../autor.service");
var forms_1 = require("@angular/forms");
var Autor_1 = require("../../Autor");
var CreateComponent = /** @class */ (function () {
    function CreateComponent(service, fb, router) {
        this.service = service;
        this.fb = fb;
        this.router = router;
        this.title = 'Adicionar Autor';
        this.autor = new Autor_1.Autor();
        this.createForm();
    }
    CreateComponent.prototype.createForm = function () {
        this.angForm = this.fb.group({
            nome: ['', forms_1.Validators.required]
        });
    };
    CreateComponent.prototype.add = function () {
        this.service.add(this.autor);
        this.router.navigate(['index']);
    };
    CreateComponent = __decorate([
        core_1.Component({
            selector: 'app-create',
            templateUrl: './create.component.html',
            styleUrls: ['./create.component.css']
        }),
        __metadata("design:paramtypes", [autor_service_1.AutorService, forms_1.FormBuilder, router_1.Router])
    ], CreateComponent);
    return CreateComponent;
}());
exports.CreateComponent = CreateComponent;
//# sourceMappingURL=create.component.js.map