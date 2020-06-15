import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {SharedModule} from './shared/shared.module';
import { AboutUsComponent } from './about-us/about-us.component';
import {AboutUsModule} from './about-us/about-us.module';
import {HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {PopoverModule} from 'ngx-bootstrap/popover';
import { AppPageComponent } from './app-page/app-page.component';

@NgModule({
  declarations: [
    AppComponent,
    AboutUsComponent,
    AppPageComponent
  ],
  imports: [
    BrowserModule,
    SharedModule,
    AboutUsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    PopoverModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
