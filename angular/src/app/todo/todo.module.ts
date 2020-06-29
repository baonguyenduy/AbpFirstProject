import { NgModule } from '@angular/core';

import { TodoComponent } from './todo.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    TodoComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ]
})
export class TodoModule {

}