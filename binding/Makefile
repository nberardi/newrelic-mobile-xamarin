BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=1.376

all: NewRelic.dll

NewRelic_iOS_Agent_$(VERSION).zip:
	@echo "You'll need to obtain a copy of NewRelic_iOS_Agent_$(VERSION).zip"
	@echo "from https://download.newrelic.com/ios_agent/NewRelic_iOS_Agent_$(VERSION).zip"
	@echo "and place it in the binding directory before running make again."
	@echo
	@open https://download.newrelic.com/ios_agent/NewRelic_iOS_Agent_$(VERSION).zip
	exit 1

libNewRelicAgent.a: NewRelic_iOS_Agent_$(VERSION).zip
	rm -rf NewRelic_iOS_Agent_$(VERSION)
	unzip $^
	cp NewRelic_iOS_Agent_$(VERSION)/NewRelicAgent.framework/NewRelicAgent libNewRelicAgent.a

NewRelic.dll: libNewRelicAgent.a
	$(BTOUCH) ApiDefinition.cs libNewRelicAgent.linkwith.cs -s:StructsAndEnums.cs --out=$@ --link-with=libNewRelicAgent.a,libNewRelicAgent.a

clean:
	-rm -rf bin obj *.a *.dll
	rm -rf NewRelic_iOS_Agent_*