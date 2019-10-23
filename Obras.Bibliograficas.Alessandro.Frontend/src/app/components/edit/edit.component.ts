import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AutorService } from '../../autor.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import {  Autor } from '../../Autor';

@Component({
	selector: 'app-edit',
	templateUrl: './edit.component.html',
	styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {

	autor: Autor;
	angForm: FormGroup;
	title = 'Editar Autor';

	constructor(private route: ActivatedRoute, private router: Router, private service: AutorService, private fb: FormBuilder) {
		this.createForm();
	}

	createForm() {
		this.angForm = this.fb.group({
			nome: ['', Validators.required]
		});
	}

	update() {
		this.route.params.subscribe(params => {
			this.service.update(this.autor, params['id']);
			this.router.navigate(['index']);
		});
	}

	ngOnInit() {
		this.route.params.subscribe(params => {
			this.service.edit(params['id']).subscribe((res: any) => {
				this.autor = res;
			});
		});
	}
}
