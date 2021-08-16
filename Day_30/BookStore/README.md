# BookStore

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 12.2.1.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.




Create an Angular Single page web page with the following features.

Add Book -  Isbn, Book Title, Description, Author, Price . Add button to add to existing book list 

Display Books -  A tabular format which should display all available books  
On click of ISBN  on each row show the Single book details component  where users should be able to modify only the Description and Price , all remaining fields are read only.

On update the details should be reflected in the display book grid.  

Nice to have : 
a. Save the booklist object t o localstorage 
b. Create a book class ts file and use the object where ever required
c. Use services to store the logics
d. Create custom directives if required 
e.  Use a good CSS and styling for each component 

Try to include the image upload option and display it as a thumbnail  in the grid