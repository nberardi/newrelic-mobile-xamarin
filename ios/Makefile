BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

VERSION=3.324

all: NewRelic.dll

NewRelic_iOS_Agent_$(VERSION).zip:
	curl -O https://download.newrelic.com/ios_agent/NewRelic_iOS_Agent_$(VERSION).zip > $@
	rm -rf NewRelic_iOS_Agent_$(VERSION)
	unzip $@

libNewRelicAgent.a: NewRelic_iOS_Agent_$(VERSION).zip
	cp NewRelic_iOS_Agent_$(VERSION)/NewRelicAgent.framework/NewRelicAgent libNewRelicAgent.a

NewRelic.dll: libNewRelicAgent.a
	$(MONOXBUILD) /p:Configuration=Release NewRelic.csproj
	cp bin/Release/NewRelic.dll NewRelic.dll

clean:
	-rm -rf bin obj *.a *.dll
	rm -rf NewRelic_iOS_Agent_*
