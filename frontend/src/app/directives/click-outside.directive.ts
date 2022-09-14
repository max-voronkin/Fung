import { Directive, ElementRef, EventEmitter, HostListener, Output } from '@angular/core';

@Directive({
  selector: '[ClickOutsideDirective]'
})
export class ClickOutsideDirective {

  @Output() public clickOutside = new EventEmitter<void>();

  constructor(private element: ElementRef) {}

  @HostListener('document:click', ['$event.target'])
  public onClick(target: any): void {
    if (!this.element.nativeElement.contains(target))
    {
      this.clickOutside.emit();
    }
  }


}
