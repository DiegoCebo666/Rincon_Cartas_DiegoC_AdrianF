import { TestBed } from '@angular/core/testing';

import { CardVendedorService } from './card-vendedor.service';

describe('CardVendedorService', () => {
  let service: CardVendedorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CardVendedorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
