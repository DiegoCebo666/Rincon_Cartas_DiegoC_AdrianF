import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserCarritoComponent } from './user-carrito.component';

describe('UserCarritoComponent', () => {
  let component: UserCarritoComponent;
  let fixture: ComponentFixture<UserCarritoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserCarritoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserCarritoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
