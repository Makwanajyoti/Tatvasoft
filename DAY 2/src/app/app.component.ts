import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { StudentComponent } from './student/student.component';
import { ServiceService } from './service.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule, StudentComponent],
  template: `
    <h1 class="header" style="text-align: center; color:rgb(15, 15, 55);">{{ title }}</h1>
    <h2 class="header" style="text-align: center; color:rgb(15, 15, 55);">{{ title2 }} information</h2>

    <app-student></app-student>

    <!-- Data from Service -->
    <h3>Data from Service</h3>
    <ul>
      <li *ngFor="let item of data">{{ item.name }}</li>
    </ul>
  `
})
export class AppComponent implements OnInit {
  title = 'Day 2';
  title2 = 'Student';
  data: any[] = [];

  constructor(private service: ServiceService) {}

  ngOnInit(): void {
    this.service.getData().subscribe(response => {
      this.data = response;
    });
  }
}
