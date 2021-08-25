# Digital Preservation: ideas from a software engineer

I spent two-and-a-bit years as Polonsky Digital Preservation Technical Fellow at [Cambridge University Library (CUL)](https://www.lib.cam.ac.uk/research/digital-preservation). My longer-term background (and current job) is in software engineering and systems development. 

So, this article starts to explore Digital Preservation from more of a software engineering perspective. **Note:** I don't know many other software engineers who ever really think about Digital Preservation much - software engineering is a very 'forward-looking' profession (often recklessly so).

## To survive, Digital Stuff has to have value to stakeholders

I'd actually like to begin by putting hands-on software engineering to one side for a minute. One of the most critical differences about Digital Stuff is that it has a different form of value to Real Stuff. So, if you have a giant. environmentally controlled barn full of precious Real Stuff, even if nobody ever goes to see any of it, *you've always got the value of the stuff inside to fall back on*. And of course you'd never sell any of it blah blah etc, but the accumulated Real Stuff is still an asset on the positive side of your ledger, one that tends to increase in value constantly, enabling you to offset your management costs. This was always painfully obvious at CUL where, for example, I used to have 1-1s with my manager while sitting in the middle of the *actual books* from [Montaigne's Library](https://cudl.lib.cam.ac.uk/collections/montaignelibrary/1). 

Of course, with Digital Stuff you don't have any of that... Possibly, maybe with [Non-Fungible Tokens](https://en.wikipedia.org/wiki/Non-fungible_token), but really, given that the first para of the Wikipedia page about them says: *"... access to any copy of the original file, however, is not restricted to the buyer of the NFT"*, no, not even with those. (I shall perhaps delve into the story of NFTs at a future juncture, and I'll get onto the topic of 'originality' below). So Digital Stuff requires completely different thinking about value, and in particular, *value to who, exactly?* 

Perhaps the most useful and important thing I read when I was CUL's Digital Preservation Technical Specialist was the [Sustainable Economics for a Digital Planet](https://discovery.ucl.ac.uk/19116/) report. This makes the important point that, to keep Digital Stuff in play, it's vital to define those with a stake in your stuff, and then align their needs, in particular the needs of *those stakeholders that use the Stuff*, and *those that pay for it to remain usable*. In other words:

* **Always know who values your Stuff and why.** Count how many people access it, talk to them about what they need it for, and if at all possible, gather real evidence of the difference it has made. Indeed, add such evidence back to the Stuff, if you can. This isn't 'Access', to be thought of separately, it's *the thing that will save your Stuff one day*. In a world where Stuff has no tangible value, the yearly budget round becomes a big preservation risk, and if you can't prove who your stuff is valuable to, and why, it can just be turned off at a stroke to provide your budget to the people that *can* prove their worth. So perhaps the main preservation task is to ensure that there's always going to be a massive outcry at the mere suggestion your stuff might be taken out of circulation.
* **Maintain the alignment between your Stuff and the core objectives of your organisation.** As objectives change, find the subsets of Stuff that are more relevant to the new direction and push those to the foreground. Or even better, *use a proven interest in your Stuff to set the agenda in the first place*. 

It should always be obvious that your Stuff matters to the people your leadership most want to cater for. Or as it says in the conclusion of the report:

*Sustainable preservation strategies will find ways to turn the uncertainties of time and resources into opportunities for flexibility, adjustments in response to changing priorities, and redirection of resources where they are most needed.*

If it's going to survive, your Stuff needs to be *flexible*, not *pickled*.

## "Digital Object" is a bad metaphor

The "Digital Objects" concept underpins Digital Preservation thinking. But "Digital Objects" like files, folders, or even chunks of metadata, are *only metaphors*. The chances of preserving Digital Stuff improve if we address the underlying realities of Computer Systems better.

* **Locking "Digital Objects" away like we do real ones is the opposite of keeping them safe.** Leaving anything Digital untouched is *never good*. Technology moves so fast: Stuff become unusable in a matter of years if not kept in play. But the tendency within Digital Preservation to "keep Digital Stuff safe" risks "keeping it unused", which will likely be the opposite of safe.
* **The original never existed.** Well, maybe in a very uninteresting state, for ten minutes, in some RAM somewhere. But that "file" you need to preserve is actually just a snapshot of a particular state of some Stuff that has a history of multiple instances and states over years or decades. Granted, it may be the only snapshot you've got access to when you first take responsibility for it, but (one way or another) it won't stay that way for long. So don't get hung up on "keeping the original the same": *it was never "the same" to begin with*. And it'll never have the provenance of a piece of paper that Churchill once smudged with cigar ash. Keeping it useful matters, keeping it "the same" is dangerous.

So:

* **To preserve Digital Stuff, we need to change it all the time.** Fluidity is much less risky than stasis. However – "format migration" is another imperfect aspect of the "file" metaphor. We need to change Stuff by *using it*. In other words…:
* **Preserve _the processes by which people interact with information_.** Locking "master files" away in a "safe place" isn’t safe, it guarantees we'll forget how to use them, sooner rather than later. The thing to preserve is the *ability to use the Stuff*, and you preserve that by actually using the Stuff.

There's a great documentary about the project to get the Flying Scotsman running again, where the historian James Baldwin explains that, to preserve an old engine, you have to: "… [strip it down to every nut, bolt and rivet](https://youtu.be/fR2kHoPsBHI?t=140)". Digital Stuff is always one part of a piece of engineering, so we're actually in the business of keeping old engines running here. Genuine knowledge of how it all works keeps it safe. The best way to understand how it works is to tinker with it, break it to pieces, and put it back together again. (Note: you're not *really* breaking it into pieces. It isn't an actual thing).

But... we don't actually have a proper concept of what "Pieces of Digital Stuff" actually are yet. Liquid / fluid metaphors (e.g.: "streams", "Data Lakes" etc) have been popular over the last couple of decades but they don't really get to the bottom of it, either (more below).

## Store information not data

Data is fundamentally useless: it's to the digital world what sand is to construction. Processing sand by melting it into glass or mixing it with cement makes it useful, but until then it just lies around in dirty heaps, getting in the way and costing money and effort to move around. The same with data: without the ability to *process it into information*, it's just annoying dirt. 

Some things about information, though, are:

* **You need an “informed party”:** information doesn't exist without a human being. (Or beings if at all possible).
* **We should welcome _all_ offers to become an "informed party".** While it definitely helps to have a particular audience in mind when presenting your Digital Stuff, audience modelling is for *their benefit, not yours*. I.e. it's easier for audience members to understand your Stuff when it's clear who it's being aimed at, even if that's someone other than them. So when people from outside the set you are aiming at show up, just be very glad they did, find out why, and add them to the set.
* **A major effort should be made to understand all "informed parties".** To be clear: not getting hung-up on "who the Designated Community for your Digital Archive will be" *does **NOT** mean “we don't care who our users are”* – **quite the opposite**.  Far better to react to, get to know, and work with the audience that shows up. Every opportunity to use your Digital Stuff strengthens the argument against switching it off. 
* **Information begets information:** not only should you understand why parties are interested, you should also find out how that interest manifested itself, and *add that back to the Stuff itself*. 

Every instance of your Stuff getting used *adds to the Stuff*. If you keep adding to it, more people care that it should be preserved, and *it's the fact people care that will preserve it*. Moving away from thinking about preserving "Digital Objects" and towards closer-to-the-digital-reality metaphors like "keeping streams going" or "enabling assemblages of linked concepts to form" ought to make this easier, once we can get such metaphors under better control.

## Use the actual Digital Stuff!

In case it's not clear yet: *using Digital Stuff preserves it*. And that means the *actual stuff*, not a lo-fi copy you made when the 'original' was squirrelled away on some expensive redundant storage somewhere, never to be touched again. That's not to say that backups shouldn't be taken (and tested) – of course they should – but then that's just prudent, professional Systems Engineering.

* **All copies should be "access copies".** The idea that there's a "back room" full of the "master copies" that should be kept "safely" out of reach just doesn't line up with how computers work. Letting someone read a "master copy" off a disc is not the same as letting them take an original artefact out of the building. So why spend extra on storage for "access copies", not to mention going to the effort of generating those copies? You can either provide users with a copy of the whole thing, or if it's easier for them, generate a lower-resolution version on the fly when required (and potentially cache that if it's one of the 250 bits of Stuff in your collection that lots of people want to look at regularly). It's cheaper, takes less management and encourages actual use of that Stuff it's costing you money to keep. Plus, why waste even more effort on "testing master copy retrieval"? If you're having to retrieve the stuff yourself to prove it's retrievable, then not enough of the people that care about it will help save it when the budget gets slim.
* **This doesn't mean security doesn't matter:** but you can still provide tightly-controlled access to your Stuff, even when people are using it all the time. At this point [the OWASP](https://owasp.org/) is probably at least as important as the OAIS... (And anyway, if the very worst happened, you've still got those working backups I mentioned, haven't you?)
* **If it ain’t broke, fix it anyway.** One of the better presentations I saw during my time at Cambridge was from the [Netherlands Sound and Film Archive](https://www.beeldengeluid.nl/en) , who had conducted a Fully-Monty OAIS-led analysis of the format they'd decided to store all their digitised films in. This showed an impressively deep *theoretical* knowledge of how their engine was supposed to work. However, that's not how engineers work: we learn how stuff works by *taking it to pieces*. So – rather than a 5000 page, OAIS-compliant format analysis that *no engineer on earth is ever going to read*, how about only storing Digital Stuff in a format once your engineering team (i.e. Mary) has proven they understand it well enough to change it into another piece of Stuff that's just as usable? That reformatting process, and the engineering knowledge needed to enact it, will be much more valuable than any document. Especially if you contribute that back to the world and improve it constantly.

## So it’s all very easy, isn’t it?

If the above has given you the impression that I know any of the answers here then I heartily apologise. Anyone can sit on the sidelines and comment about how we're doing it wrong by treating "Digital Objects" as if they're digital versions of the paper that was mashed through Winston Churchill's typewriter. (And I met plenty of people in the Digital Preservation business who were as worried by the metaphor as I, of course).

The thing is, though, that I've been using the terrible-but-still-better-than-anything-else-I-can-think-of term: "Digital Stuff" throughout all the above. And there's the rub: to actually preserve Digital Stuff properly, *we need to define what it is better*. Only then will we be able to develop systems that match how people use it and the value it brings, now and for long into the future. 

Files, folders and metadata really don't cut it. Nor do even vaguer terms such as 'content' or 'assets', which still imply coherent, whole 'things' with beginnings, middles and ends. A "piece of Digital Stuff" is something more like a technologically-assisted exploration of ideas or concepts, which weaves its way in and out of real-world contexts as time passes. (You can have that one for free - though it feels like it needs a bit of work...)

Fluid metaphors such as streams, lakes, etc get us a bit closer but they're still not right, because they don't take the "snapshot" aspect of working with Digital Stuff into account very well. (I.e. the idea that from time to time a human being will grasp the Stuff and do something with it; something that hopefully changes it in some way and adds to its story)..: 

*"It's kind of an unconstrained stream that could potentially keep running and running, but a stream that crystallises every so often and then forks into multiple new streams at that point. Then those streams morph into new streams that eventually might coalesce back into one tiny, trickling stream again. And then that stream crystallises again and..."* 

**Urgh!**

Getting to a decent, solid definition for Digital Stuff is going to be a recurring theme here, because once we have accurately modelled the domain we're working in, we can really get going.

