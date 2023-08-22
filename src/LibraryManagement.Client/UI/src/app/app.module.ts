import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { HeaderComponent } from './shared/header/header.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './pages/home/home.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { BookItemComponent } from './components/book-item/book-item.component';
import BookService from './services/book.service';
import { SignupComponent } from './pages/authentication/signup/signup.component';
import { LoginComponent } from './pages/authentication/login/login.component';
import { AdminModule } from './admin/admin.module';
import AuthorService from './services/author.service';
import BookCategoryService from './services/book-category.service';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SignupComponent,
    LoginComponent,
    HomeComponent,
    BookItemComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FontAwesomeModule,
    AdminModule
  ],
  providers: [BookService, BookCategoryService, AuthorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
