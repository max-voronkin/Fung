import { Component, forwardRef, Input } from '@angular/core';
import { IconDefinition } from '@fortawesome/fontawesome-svg-core';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';

@Component({
  selector: 'fung-input',
  templateUrl: './fung-input.component.html',
  styleUrls: ['./fung-input.component.sass'],
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      multi: true,
      useExisting: forwardRef(() => FungInputComponent),
    },
  ]
})
export class FungInputComponent implements ControlValueAccessor{

  @Input() public type = 'text';
  @Input() public errorMessage = '';
  @Input() public width = '100%';
  @Input() public height = '40px';
  @Input() public placeholder = 'Enter some...'
  @Input() public icon?: IconDefinition = undefined;
  @Input() public iconPosition = 'right';
  @Input() public inputValue = '';
  @Input() public marginTop = '';
  @Input() public label = '';

  constructor() { }

  onChange: (value: Event) => void = () => { };

  onTouched: (value: Event) => void = () => { };

  writeValue(value: string): void {
    this.inputValue = value;
  }

  registerOnChange(fn: (value: Event) => void): void {
    this.onChange = fn;
  }

  registerOnTouched(fn: (value: Event) => void): void {
    this.onTouched = fn;
  }

}
