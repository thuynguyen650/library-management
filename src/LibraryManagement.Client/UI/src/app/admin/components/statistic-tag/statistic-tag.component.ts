import { Component, Input } from '@angular/core';
import { IconDefinition, faBook } from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-statistic-tag',
  templateUrl: './statistic-tag.component.html',
  styleUrls: ['./statistic-tag.component.sass']
})
export class StatisticTagComponent {
  @Input()
  faIcon: IconDefinition = faBook;

  @Input()
  name: string = '...';

  @Input()
  statistic: number = 0;

  @Input()
  backgroundColor: string = 'bg-gray-200';

  @Input()
  borderColor: string = 'border-gray-400';
  
  @Input()
  iconBackgroundColor: string = 'bg-gray-700';
  
  @Input()
  textColor: string = 'text-gray-800';
}
