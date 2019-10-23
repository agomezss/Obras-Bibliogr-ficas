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
	autores: Autor[];
	total: number = 1;

	constructor(private service: AutorService, private fb: FormBuilder, private router: Router) {

	}

	updateTotal() {
		this.autores = [];

		for (let index = 0; index < this.total; index++) {
			let novoAutor = new Autor();
			this.autores.push(novoAutor);
		}
	}


	add() {
		this.service.add(this.autores);
		this.router.navigate(['index']);
	}
}
