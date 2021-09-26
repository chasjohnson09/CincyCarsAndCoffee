import { NgModule } from "@angular/core";
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatButtonModule } from '@angular/material/button';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatCardModule } from '@angular/material/card';
import {MatDividerModule} from '@angular/material/divider';
import {MatToolbarModule} from '@angular/material/toolbar';


@NgModule({
    imports: [

        MatSidenavModule,
        MatButtonModule,
        FlexLayoutModule,
        MatCardModule,
        MatDividerModule,
        MatToolbarModule,
        MatButtonModule,


       
        
    ],
    exports: [
        MatSidenavModule,
        MatButtonModule,
        FlexLayoutModule,
        MatCardModule,
        MatDividerModule,
        MatToolbarModule,
        MatButtonModule
        
    ]
})
export class MaterialModule {
    
}