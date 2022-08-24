import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-main-page-overlay',
  templateUrl: './main-page-overlay.component.html',
  styleUrls: ['./main-page-overlay.component.sass']
})
export class MainPageOverlayComponent implements OnInit {

  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    if(!this.route.snapshot.firstChild)
    {
      this.router.navigate(['stations'], {relativeTo: this.route, replaceUrl: true});
    }
  }
  
}
