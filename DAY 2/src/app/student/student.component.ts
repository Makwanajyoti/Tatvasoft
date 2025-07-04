import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DirectiveComponent } from "../directive/directive.component";

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule, CommonModule, DirectiveComponent],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent {
  name:string='';
  content:string=''
  type:string='text'
  eventBind(){
    this.content="your name is :"+this.name
  }
}
