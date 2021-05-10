import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { West } from '../west.class';
import { WestService } from '../west.service';

@Component({
  selector: 'app-west-detail',
  templateUrl: './west-detail.component.html',
  styleUrls: ['./west-detail.component.css']
})
export class WestDetailComponent implements OnInit {

  west: West = null;
  id: number = 0;

  constructor(
    private wstsvc: WestService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params.id;
    this.wstsvc.get(+this.id).subscribe(
      res => {
        console.log("West Event:", res);
        this.west = res;
      },
      err => {
        console.error(err);
      }
    );
  }

}