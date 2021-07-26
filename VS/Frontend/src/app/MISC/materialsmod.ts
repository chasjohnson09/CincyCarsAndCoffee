import { NgModule } from "@angular/core";
import { MatSidenavModule } from'@angular/material/sidenav';
import { MatButtonModule } from'@angular/material/button';
import { FlexLayoutModule } from '@angular/flex-layout';

@NgModule({
    imports: [

        MatSidenavModule,
        MatButtonModule,
        FlexLayoutModule
    ],
    exports: [
        MatSidenavModule,
        MatButtonModule,
        FlexLayoutModule
    ]
})
export class MaterialModule {}