import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { EquipoListDto, EquipoServiceProxy } from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: './teams.component.html',
  animations: [appModuleAnimation()],
  styleUrls: ['./teams.component.css']
})
export class TeamsComponent extends AppComponentBase {
  equipos: EquipoListDto[] = []
  filtro: string = '';

  constructor(
    injector: Injector,
    private _equipoService: EquipoServiceProxy
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.getEquipos()
  }

  getEquipos(): void {
    this._equipoService.getEquipos(this.filtro).subscribe(result => {
      console.log(result.items)
      this.equipos = result.items;
    })
  }
}
