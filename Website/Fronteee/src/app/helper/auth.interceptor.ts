import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { AuthService } from "../service/auth.service";


@Injectable()
export class AuthInterceptor implements HttpInterceptor
{


    constructor(private authse : AuthService){

    }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
       

        const token = localStorage.getItem(this.authse.tokenName);

        if(token)
        {

            const reqClone = req.clone({
               headers : req.headers.set("Authorization",`Bearer ${token}`)
            });

            //return next.handle(req);
              return next.handle(reqClone);
        }else{

            return next.handle(req);
        }

    }
    
}