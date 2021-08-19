import { Component, NgModule } from "@angular/core";
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatCardModule } from '@angular/material/card';

@NgModule({
    imports: [

        MatSidenavModule,
        MatButtonModule,
        FlexLayoutModule,
        MatCardModule,
        Component
    ],
    exports: [
        MatSidenavModule,
        MatButtonModule,
        FlexLayoutModule,
        MatCardModule
    ]
})
export class MaterialModule {
    constructor() { }
}