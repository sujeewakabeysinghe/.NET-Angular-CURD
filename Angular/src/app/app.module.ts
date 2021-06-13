import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeesComponent } from './employees/employees.component';
import { DepartmentsComponent } from './departments/departments.component';
import { AddEmployeeComponent } from './employees/add-employee/add-employee.component';
import { ShowEmployeeComponent } from './employees/show-employee/show-employee.component';
import { EditEmployeeComponent } from './employees/edit-employee/edit-employee.component';
import { AddDepartmentComponent } from './departments/add-department/add-department.component';
import { ShowDepartmentComponent } from './departments/show-department/show-department.component';
import { EditDepartmentComponent } from './departments/edit-department/edit-department.component';
import { DepartmentService } from './services/department.service';
import { EmployeeService } from './services/employee.service'

@NgModule({
  declarations: [
    AppComponent,
    EmployeesComponent,
    DepartmentsComponent,
    AddEmployeeComponent,
    ShowEmployeeComponent,
    EditEmployeeComponent,
    AddDepartmentComponent,
    ShowDepartmentComponent,
    EditDepartmentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    DepartmentService,
    EmployeeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
