export class cartaCarrito2 {
    carritoFId: number;
    cartaVendedorFId: number;
    fCantidad: number;
}

export class cartaCarrito {
    cartaCarritoId: number;
    carritoFId: number;
    cartaVendedorFId: number;
    fCantidad: number;
}

export class cartaCarritoAllData {
    cartaCarritoId: number;
    carritoFId: number;
    cartaVendedorFId: [{
        CartaFName: String;
        Precio: number;
    }];
    fCantidad: number;
}