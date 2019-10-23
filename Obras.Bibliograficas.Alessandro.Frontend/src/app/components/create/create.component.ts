import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { AutorService } from '../../autor.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Autor } from '../../Autor';

@Component({
	selector: 'app-create',
	templateUrl: './create.component.html',
	styleUrls: ['./create.component.css']
})
export class CreateComponent {

	title = 'Adicionar Autor';
	angForm: FormGroup;
	autor: Autor;

	constructor(private service: AutorService, private fb: FormBuilder, private router: Router) {

		this.autor = new Autor();
		this.createForm();
	}

	createForm() {
		this.angForm = this.fb.group({
			nome: ['', Validators.required]
		});
	}

	add() {
		this.service.add(this.autor);
		this.router.navigate(['index']);
	}
}
