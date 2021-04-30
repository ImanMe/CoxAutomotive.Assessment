import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BestSellingVehicleComponent } from './best-selling-vehicle.component';

describe('BestSellingVehicleComponent', () => {
  let component: BestSellingVehicleComponent;
  let fixture: ComponentFixture<BestSellingVehicleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BestSellingVehicleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BestSellingVehicleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
