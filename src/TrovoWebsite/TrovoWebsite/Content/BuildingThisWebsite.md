## About this website

Let's begin with the story of how this markdown was rendered on the Home Page.

1. I setup the bare minimum MVC project in .Net 4.6.1 (because my web hosting is cheap / cheerful / old).
2. I added the [Markdig](https://github.com/xoofx/markdig) Nuget package.
3. I added the first test for a simple file accessor.
4. I used the file accessor to render markdown in the HomeController, and add the result to the ViewBag.
5. Then I just tried to put the bare minimum [Bootstrap](https://getbootstrap.com) in to get a layout working.

It's pretty much been the dictionary definition of JAFLOC (Just A Few Lines Of Code) to get the basics of a blog that I can  manage with a Markdown editor.

You can [get into its innards](https://github.com/TrovoLtd/TrovoWebsite) on GitHub, with the added bonus that the Markdown that's rendered here gets version controlled over there... So I'll never be able get away with doing a Dominic Cummings and editing any of this after the fact to make myself look clever. 

### To do next

- Deploy!
- Write lots!
- Get the HomeController tests uncommented out and working OK - which might need Dependency Injection sorting out, or at least some chained constructors.
- Realise that I can't access the Markdown because of how the permissions are set up on my web hosting! (That'll be annoying if it happens...)
- Refactor the Markdown generation away from the Controller, so that the Controller's only job is to chuff strings of HTML to the View. (Probably make it all static).
- Make it look nicer. (There's all sorts of pipelines for rendering Markdown with Bootstrap etc etc).

### To do eventually

- Oooh the possibilities! It'll need navigation, and a responsive design, and a search engine. 
- And lions, and tigers, and bears, oh my!