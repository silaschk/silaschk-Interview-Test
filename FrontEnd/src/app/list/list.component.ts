import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css'],
})
export class ListComponent implements OnInit {
  heroes: any[] = [];
  heroUpdated: any | null = null;

  constructor(private apiService: ApiService) {}

  ngOnInit(): void {
    this.loadHeroes();
  }

  loadHeroes(): void {
    this.apiService.getHeroes().subscribe((heroes) => {
      this.heroes = heroes;
    });
  }

  evolveHero(heroName: string): void {
    this.apiService.evolveHero(heroName).subscribe((updatedHero) => {
      this.heroUpdated = updatedHero;
      this.loadHeroes(); // Reload the hero list after evolution
    });
  }
}
