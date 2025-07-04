import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-directive',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './directive.component.html',
  styleUrl: './directive.component.css'
})
export class DirectiveComponent {
  set:boolean=false
  arr:string[]=['python','php','java','js']
  eventBind2(){
    this.set=true
  }
}
