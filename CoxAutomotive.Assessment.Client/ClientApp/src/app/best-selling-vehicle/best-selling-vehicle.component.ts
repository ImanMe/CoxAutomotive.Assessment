import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-best-selling-vehicle',
  templateUrl: './best-selling-vehicle.component.html',
  styleUrls: ['./best-selling-vehicle.component.css']
})
export class BestSellingVehicleComponent implements OnInit {

  @Input() mostSoldVehicle: string;
  constructor() { }

  ngOnInit(): void {
  }
}
