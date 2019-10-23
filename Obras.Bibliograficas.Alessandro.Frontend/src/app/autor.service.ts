import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import 'rxjs/add/operator/map';

@Injectable()
export class AutorService {

	constructor(private http: HttpClient) { }

	add(obj) {
		const uri = 'http://localhost:58754/api/autor';
		this
			.http
			.post(uri, obj)
			.subscribe(res =>
				console.log(res));
	}

	get() {
		const uri = 'http://localhost:58754/api/autor';
		return this
			.http
			.get(uri)
			.map(res => {
				console.log(res);
				return res;
			});
	}

	edit(id) {
		const uri = 'http://localhost:58754/api/autor/' + id;
		return this
			.http
			.get(uri)
			.map(res => {
				return res;
			});
	}

	update(obj, id) {
		const uri = 'http://localhost:58754/api/autor/' + id;

		this
			.http
			.put(uri, obj)
			.subscribe(res => console.log(res));
	}

	delete(id) {
		const uri = 'http://localhost:58754/api/autor/' + id;

		return this
			.http
			.delete(uri)
			.map(res => {
				return res;
			});
	}
}
