import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.module';
var platform = platformBrowserDynamic();
platform.bootstrapModule(AppModule);
//reload the app when you changed code
if (module.hot) {
    module.hot.accept();
    module.hot.dispose(function () {
        // create a new 'app' before start
        var oldRootElem = document.querySelector('app');
        var newRootElem = document.createElement('app');
        oldRootElem.parentNode.insertBefore(newRootElem, oldRootElem);
        platform.destroy();
    });
}
//# sourceMappingURL=main.js.map