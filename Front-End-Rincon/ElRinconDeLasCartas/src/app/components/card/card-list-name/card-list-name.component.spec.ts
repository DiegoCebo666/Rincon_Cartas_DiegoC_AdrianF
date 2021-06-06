import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardListNameComponent } from './card-list-name.component';

describe('CardListNameComponent', () => {
  let component: CardListNameComponent;
  let fixture: ComponentFixture<CardListNameComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CardListNameComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CardListNameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
