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

	print(): void {

		let popupWin = window.open('', '_blank', 'top=0,left=0,height=100%,width=auto');
		let autoresHtml = '';

		this.autores.forEach(element => {

			if(!element && !element.nomeFormatado) return;

			autoresHtml += `<tr>
				<td>${element.nomeFormatado}</td>
			</tr>`;
		});

		popupWin.document.open();
		popupWin.document.write(`
			<html>
				<body>
					<h1>Autores</h1>
					<table>
						<thead>
						<tr>
							<td>Nome do autor</td>
						</tr>
						</thead>
						<tbody>
							${autoresHtml}
						</tbody>
					</table>
				</body>
			</html>`
		);

		popupWin.document.close();
		popupWin.print();
		popupWin.close();
	}
}
