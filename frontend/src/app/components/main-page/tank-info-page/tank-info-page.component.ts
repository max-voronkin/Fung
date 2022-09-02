import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-tank-info-page',
  templateUrl: './tank-info-page.component.html',
  styleUrls: ['./tank-info-page.component.sass']
})
export class TankInfoPageComponent implements OnInit {

  tankId!: number;
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.tankId = params.get('id') as unknown as number;
    });
  }

}
