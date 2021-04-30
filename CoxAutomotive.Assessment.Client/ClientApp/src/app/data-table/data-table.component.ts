import { Component, Input, OnInit } from '@angular/core';
import { Deal } from '../models/deal';

@Component({
  selector: 'app-data-table',
  templateUrl: './data-table.component.html',
  styleUrls: ['./data-table.component.css']
})
export class DataTableComponent implements OnInit {
  @Input() deals: Deal[];
  panelOpenState = true;
  
  dataSource: Deal[] = [];
  displayedColumns: string[] = ['dealNumber', 'customerName', 'dealershipName', 'vehicle', 'price', 'date'];
  constructor() { }

  ngOnInit(): void {
  }
}
