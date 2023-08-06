import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StatisticTagComponent } from './statistic-tag.component';

describe('StatisticTagComponent', () => {
  let component: StatisticTagComponent;
  let fixture: ComponentFixture<StatisticTagComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StatisticTagComponent]
    });
    fixture = TestBed.createComponent(StatisticTagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
