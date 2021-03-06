import { Injectable } from '@angular/core';
import { Result } from '../models/result';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FileUploadService {

  constructor(private http: HttpClient) { }

  upload = (file: File) => {
    const fileToUpload = <File>file;
    const formData = new FormData();
    formData.append('file', fileToUpload);
    return this.http.post<Result>('/api/upload', formData);
  }
}
