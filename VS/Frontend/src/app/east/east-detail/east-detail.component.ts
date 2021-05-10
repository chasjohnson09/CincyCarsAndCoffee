import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { East } from '../east.class';
import { EastService } from '../east.service';

@Component({
  selector: 'app-east-detail',
  templateUrl: './east-detail.component.html',
  styleUrls: ['./east-detail.component.css']
})
export class EastDetailComponent implements OnInit {

  east: East = null;
  id: number = 0;

  constructor(
    private estsvc: EastService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params.id;
    this.estsvc.get(+this.id).subscribe(
      res => {
        console.log("East Event:", res);
        this.east = res;
      },
      err => {
        console.error(err);
      }
    );
  }

}