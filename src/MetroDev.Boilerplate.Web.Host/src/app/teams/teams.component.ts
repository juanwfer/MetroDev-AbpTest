import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  templateUrl: './teams.component.html',
  animations: [appModuleAnimation()],
  styleUrls: ['./teams.component.css']
})
export class TeamsComponent extends AppComponentBase {
  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit(): void {
  }

}
