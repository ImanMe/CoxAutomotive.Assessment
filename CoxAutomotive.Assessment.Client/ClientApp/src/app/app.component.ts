import { Component } from '@angular/core';
import { Result } from './models/result';
import { FileUploadService } from './services/file-upload.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Assessment';
  centered = false;
  disabled = false;
  unbounded = false;
  radius: number;
  color: string;
  result:Result;
  isDataDisplayed = false;
  errorMessage = '';

  constructor(private uploadService: FileUploadService) {    
  }

  public uploadFile = (event) => {
    const file = event.target.files[0];
    this.uploadService.upload(file)
      .subscribe(arg => {
        this.result = arg;
        this.isDataDisplayed = true;
        this.errorMessage = '';
      },err => {
          this.errorMessage = err.error;
          this.isDataDisplayed = false;
      });
  }
}
