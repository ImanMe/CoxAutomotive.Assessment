import { Component, OnInit } from '@angular/core';
import { Result } from '../models/result';
import { FileUploadService } from '../services/file-upload.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})


export class HomeComponent implements OnInit {
 
  hasData = false;
  hasError = false;
  errorMessage = '';
  result:Result;
  constructor(private uploadService:FileUploadService) {}

  ngOnInit(): void {
    
  }
  
  

  allowUpload = () => {

  }

  clear = () => {
    this.hasData = false;
    this.hasError = false;
  }

  uploadFile = (event) => {
    const file = event.target.files[0];
    this.uploadService.upload(file).subscribe(data => {
      this.result = data;
      this.hasData = true;
      this.hasError = false;
    }, err => {
      this.errorMessage = err.error;
      this.hasError = true;
      this.hasData=false;
    });
  }
}
