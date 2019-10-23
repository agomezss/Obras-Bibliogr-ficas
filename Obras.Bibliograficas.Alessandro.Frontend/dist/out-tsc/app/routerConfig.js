"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var create_component_1 = require("./components/create/create.component");
var edit_component_1 = require("./components/edit/edit.component");
var index_component_1 = require("./components/index/index.component");
exports.appRoutes = [
    { path: 'create',
        component: create_component_1.CreateComponent
    },
    {
        path: 'edit/:id',
        component: edit_component_1.EditComponent
    },
    { path: 'index',
        component: index_component_1.IndexComponent
    }
];
//# sourceMappingURL=routerConfig.js.map