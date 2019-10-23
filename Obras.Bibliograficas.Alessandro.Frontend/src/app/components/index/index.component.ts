import { AutorService } from '../../autor.service';
import { Component, OnInit, AfterViewInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Autor } from '../../Autor';

@Component({
	selector: 'app-index',
	templateUrl: './index.component.html',
	styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit, AfterViewInit {

	autores: Autor[];

	constructor(private http: HttpClient, private service: AutorService) { }

	ngOnInit() {
		this.getAutores();
	}

	ngAfterViewInit() {
		this.getAutores();
	}

	getAutores() {
		this.service.get().subscribe((res: any) => {
			this.autores = res;
		});
	}
	
	delete(id) {
		this.service.delete(id).subscribe(res => {
			this.getAutores();
		});
	  }
}
