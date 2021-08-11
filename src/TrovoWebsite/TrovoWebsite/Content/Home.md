## Welcome to the Trovo Website

Let's begin with the story of how this markdown was rendered on the Home Page.

1. I setup the bare minimum MVC project in .Net 6.1 (because my web hosting is cheap / cheerful / old).
2. I added the [Markdig](https://github.com/xoofx/markdig) Nuget package.
3. I added the first test for a simple file accessor.
4. I used that to return this very file in the HomeController, and add it to the ViewBag.
5. Then I just tried to put the bare minimum [Bootstrap](https://getbootstrap.com) in to get a layout working

It wasn't rendering links properly because I wrote the Markdown wrong... :)

### To do next

Deploy!

Get the HomeController tests uncommented out and working OK - which might need Dependency Injection sorting out, or at least some chained constructors.

Realise that I can't access the file because of how the permissions are set up on my web hosting!

Refactor the Markdown generation away from the Controller, so that the Controller's only job is to chuff strings of HTML to the View. (Probably make it all static).

Make it look nice. (There's all sorts of pipelines for rendering Markdown with Bootstrap etc etc.

### To do eventually

Oooh the possibilities! It'll need navigation, and a responsive design, and a search engine. 

And lions, and tigers, and bears, oh my!

Etc.