import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatIconModule } from '@angular/material/icon'
import {MatButtonModule} from '@angular/material/button';


import { AppComponent } from './app.component';
import { BoardComponent } from './board/board.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    BoardComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    MatIconModule,
    MatButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
