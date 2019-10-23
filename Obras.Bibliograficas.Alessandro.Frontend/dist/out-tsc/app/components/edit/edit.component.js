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
var router_1 = require("@angular/router");
var autor_service_1 = require("../../autor.service");
var forms_1 = require("@angular/forms");
var EditComponent = /** @class */ (function () {
    function EditComponent(route, router, service, fb) {
        this.route = route;
        this.router = router;
        this.service = service;
        this.fb = fb;
        this.title = 'Editar Autor';
        this.createForm();
    }
    EditComponent.prototype.createForm = function () {
        this.angForm = this.fb.group({
            nome: ['', forms_1.Validators.required]
        });
    };
    EditComponent.prototype.update = function () {
        var _this = this;
        this.route.params.subscribe(function (params) {
            _this.service.update(_this.autor, params['id']);
            _this.router.navigate(['index']);
        });
    };
    EditComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.params.subscribe(function (params) {
            _this.service.edit(params['id']).subscribe(function (res) {
                _this.autor = res;
            });
        });
    };
    EditComponent = __decorate([
        core_1.Component({
            selector: 'app-edit',
            templateUrl: './edit.component.html',
            styleUrls: ['./edit.component.css']
        }),
        __metadata("design:paramtypes", [router_1.ActivatedRoute, router_1.Router, autor_service_1.AutorService, forms_1.FormBuilder])
    ], EditComponent);
    return EditComponent;
}());
exports.EditComponent = EditComponent;
//# sourceMappingURL=edit.component.js.map