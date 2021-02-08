import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from './product';

@Component({
  selector: 'app-product',
  templateUrl: '../product/product.component.html'
})
export class ProductComponent implements OnInit {
  title = 'app';
  path = "";
  filterProduct = "";
  products: Product[];
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.path = baseUrl + "api/Products/getproducts";
  }

  ngOnInit(): void {
    this.http.get<Product[]>(this.path).subscribe(data => {
      this.products = data;
    });
  }
 
}
