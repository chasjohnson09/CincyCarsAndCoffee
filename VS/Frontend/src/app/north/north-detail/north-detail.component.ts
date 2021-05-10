import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { North } from '../north.class';
import { NorthService } from '../north.service';

@Component({
  selector: 'app-north-detail',
  templateUrl: './north-detail.component.html',
  styleUrls: ['./north-detail.component.css']
})
export class NorthDetailComponent implements OnInit {

  north: North = null;
  id: number = 0;

  constructor(
    private nrthsvc: NorthService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params.id;
    this.nrthsvc.get(+this.id).subscribe(
      res => {
        console.log("North Event:", res);
        this.north = res;
      },
      err => {
        console.error(err);
      }
    );
  }

}
