import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
//import { saveAs } from 'file-saver';
import { saveAs } from 'file-saver';

 

@Component({
  selector: 'app-verifymerchant',
  templateUrl: './verifymerchant.component.html',
  styleUrls: ['./verifymerchant.component.scss']
})
export class VerifymerchantComponent implements OnInit {

  constructor(private http:  HttpClient) {
    this.getAllFiles();
   }
   files: any = [];
  getAllFiles()
  {
     
    return this.http.get('https://localhost:7056/api/Managers/getNotverifiedMerch')
    .subscribe((result) => {
      this.files = result;
      console.log(result);
  });
  }
  downloadFile(id: number, contentType: string)
  {
    return this.http.get(`https://localhost:7056/api/Files/download/${id}`, {responseType: 'blob'})
    .subscribe((result: Blob) => {
      const blob = new Blob([result], { type: contentType });
       saveAs(blob, contentType);

     // const blob = new Blob([result], { type: contentType }); // you can change the type
     // const url= window.URL.createObjectURL(blob);
     // window.open(url);
      console.log(result);
  });
  }

  ngOnInit(): void {
  }

}
