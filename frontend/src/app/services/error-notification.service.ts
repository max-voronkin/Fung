import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class ErrorNotificationService {

  public constructor(private snackBar: MatSnackBar) {}

  public showErrorMessage(error: any) {
      this.snackBar.open(error, '', { duration: 3000, panelClass: 'error-snack-bar' });
  }

  public showInfoMessage(message: any) {
      this.snackBar.open(message, '', { duration: 3000, panelClass: 'info-snack-bar' });
  }
}
