import { PipeTransform, Pipe } from "@angular/core";
import { Product } from "./product";

@Pipe({
  name:"productFilter"
})
export class ProductPipe implements PipeTransform {
  transform(value: Product[], filterProduct: string): Product[] {
    filterProduct = filterProduct ? filterProduct.toLowerCase() : null;

    return filterProduct ? value.filter((p: Product) => p.productName.toLowerCase().indexOf(filterProduct) !== -1) : value;
  }
}
